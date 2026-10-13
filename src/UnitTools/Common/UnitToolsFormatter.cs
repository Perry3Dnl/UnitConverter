namespace UnitTools
{
    using System;
    using System.Globalization;
    using UnitTools.Catalog;

    /// <summary>
    /// Selects how a unit is represented in formatted text.
    /// </summary>
    public enum UnitToolsUnitFormat
    {
        Symbol = 0,
        DisplayName = 1,
        EnumName = 2,
    }

    /// <summary>
    /// Formats numeric values with catalog unit symbols, localized display names, or stable enum names.
    /// </summary>
    public static class UnitToolsFormatter
    {
        public static string Format<TUnit>(double value, TUnit unit)
            where TUnit : struct
        {
            return Format(
                value,
                unit,
                "G",
                CultureInfo.InvariantCulture,
                UnitToolsUnitFormat.Symbol);
        }

        public static string Format<TUnit>(
            double value,
            TUnit unit,
            IFormatProvider formatProvider)
            where TUnit : struct
        {
            return Format(
                value,
                unit,
                "G",
                formatProvider,
                UnitToolsUnitFormat.Symbol);
        }

        public static string Format<TUnit>(
            double value,
            TUnit unit,
            UnitToolsUnitFormat unitFormat)
            where TUnit : struct
        {
            return Format(
                value,
                unit,
                "G",
                CultureInfo.InvariantCulture,
                unitFormat);
        }

        public static string Format<TUnit>(
            double value,
            TUnit unit,
            string numberFormat,
            IFormatProvider formatProvider,
            UnitToolsUnitFormat unitFormat)
            where TUnit : struct
        {
            UnitToolsFamilyDescriptor<TUnit> family;
            if (!UnitToolsCatalog.TryGetFamily(out family))
            {
                throw new NotSupportedException(
                    "No unit family descriptor is registered for " + typeof(TUnit).FullName + ".");
            }

            UnitToolsUnitDescriptor descriptor = family.GetUnit(unit);
            string unitText;

            switch (unitFormat)
            {
                case UnitToolsUnitFormat.Symbol:
                    unitText = descriptor.Symbol;
                    break;
                case UnitToolsUnitFormat.DisplayName:
                    unitText = UnitToolsLocalization.GetDisplayName(
                        unit,
                        formatProvider ?? CultureInfo.InvariantCulture,
                        descriptor.DisplayName);
                    break;
                case UnitToolsUnitFormat.EnumName:
                    unitText = descriptor.Name;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(unitFormat),
                        unitFormat,
                        "Unsupported unit format.");
            }

            return value.ToString(
                string.IsNullOrEmpty(numberFormat) ? "G" : numberFormat,
                formatProvider ?? CultureInfo.InvariantCulture) +
                " " +
                unitText;
        }
    }
}