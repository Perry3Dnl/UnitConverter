namespace UnitConverter
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Globalization;

    /// <summary>Immutable metadata for one named unit.</summary>
    public sealed class UnitConverterUnitInfo
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Symbol { get; private set; }
        public string DisplayName { get; private set; }
        public UnitConverterUnitSystem System { get; private set; }
        public bool SupportsDecimal { get { return RationalTo != null && RationalFrom != null; } }
        public IReadOnlyDictionary<string, IReadOnlyList<string>> Abbreviations { get; private set; }
        internal string Plural { get; private set; }
        internal string RationalTo { get; private set; }
        internal string RationalFrom { get; private set; }

        internal UnitConverterUnitInfo(int id, string name, string symbol, string displayName, UnitConverterUnitSystem system,
            string plural, string rationalTo, string rationalFrom, string[] cultures, string[][] abbreviations)
        {
            Id = id; Name = name; Symbol = symbol; DisplayName = displayName; System = system;
            Plural = plural; RationalTo = rationalTo; RationalFrom = rationalFrom;
            var map = new Dictionary<string, IReadOnlyList<string>>(StringComparer.OrdinalIgnoreCase);
            for (var i = 0; i < cultures.Length; i++) map.Add(cultures[i], Array.AsReadOnly((string[])abbreviations[i].Clone()));
            Abbreviations = new ReadOnlyDictionary<string, IReadOnlyList<string>>(map);
        }

        public string GetSymbol(IFormatProvider provider)
        {
            var culture = provider as CultureInfo ?? CultureInfo.CurrentCulture;
            IReadOnlyList<string> symbols;
            if (Abbreviations.TryGetValue(culture.Name, out symbols) && symbols.Count > 0) return symbols[0];
            if (Abbreviations.TryGetValue(culture.TwoLetterISOLanguageName, out symbols) && symbols.Count > 0) return symbols[0];
            return Symbol;
        }
    }
}
