namespace UnitConverter
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    internal static class UnitConverterText
    {
        internal static bool IsFinite(double value) { return !double.IsNaN(value) && !double.IsInfinity(value); }

        internal static bool TryUnit(string text, IReadOnlyList<UnitConverterUnitInfo> units, IFormatProvider provider, out int id)
        {
            id = -1;
            if (string.IsNullOrWhiteSpace(text)) return false;
            text = text.Trim();
            var culture = provider as CultureInfo ?? CultureInfo.CurrentCulture;
            // Symbols are case sensitive (mW and MW must never be confused).
            foreach (var unit in units)
            {
                var match = string.Equals(text, unit.Symbol, StringComparison.Ordinal);
                foreach (var entry in unit.Abbreviations)
                {
                    if (entry.Key != "en-US" && !string.Equals(entry.Key, culture.Name, StringComparison.OrdinalIgnoreCase)
                        && !string.Equals(entry.Key, culture.TwoLetterISOLanguageName, StringComparison.OrdinalIgnoreCase)) continue;
                    foreach (var symbol in entry.Value) if (symbol.Length > 0 && string.Equals(text, symbol, StringComparison.Ordinal)) match = true;
                }
                if (!match) continue;
                if (id >= 0 && !Equivalent(units[id], unit)) { id = -1; return false; }
                if (id < 0) id = unit.Id;
            }
            if (id >= 0) return true;
            foreach (var unit in units)
            {
                if (!string.Equals(text, unit.Name, StringComparison.OrdinalIgnoreCase)
                    && !string.Equals(text, unit.DisplayName, StringComparison.OrdinalIgnoreCase)
                    && !string.Equals(text, unit.Plural, StringComparison.OrdinalIgnoreCase)) continue;
                if (id >= 0 && !Equivalent(units[id], unit)) { id = -1; return false; }
                if (id < 0) id = unit.Id;
            }
            return id >= 0;
        }

        private static bool Equivalent(UnitConverterUnitInfo a, UnitConverterUnitInfo b)
        {
            // Aliases must describe exactly the same transform to resolve automatically.
            return a.RationalTo != null && a.RationalTo == b.RationalTo;
        }

        internal static bool TryValue(string text, IReadOnlyList<UnitConverterUnitInfo> units, IFormatProvider provider, out double value, out int id)
        {
            value = 0; id = -1;
            if (string.IsNullOrWhiteSpace(text)) return false;
            text = text.Trim();
            for (var split = text.Length - 1; split > 0; split--)
            {
                double candidate; int candidateId;
                if (!double.TryParse(text.Substring(0, split).Trim(), NumberStyles.Float, provider ?? CultureInfo.CurrentCulture, out candidate)
                    || !IsFinite(candidate)) continue;
                if (!TryUnit(text.Substring(split), units, provider, out candidateId)) continue;
                value = candidate; id = candidateId; return true;
            }
            return false;
        }
    }
}
