namespace UnitConverter
{
    using System;
    using System.Globalization;
    using UnitConverter.Catalog;

    /// <summary>
    /// Selects how a unit is represented in formatted text.
    /// </summary>
    public enum UnitConverterUnitFormat
    {
        Symbol = 0,
        DisplayName = 1,
        EnumName = 2,
    }

    /// <summary>
    /// Formats numeric values with catalog unit symbols, localized display names, or stable enum names.
    /// </summary>
    public static class UnitConverterFormatter
    {
        public static string Format<TUnit>(double value, TUnit unit)
            where TUnit : struct
        {
            return Format(
                value,
                unit,
                "G",
                CultureInfo.InvariantCulture,
                UnitConverterUnitFormat.Symbol);
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
                UnitConverterUnitFormat.Symbol);
        }

        public static string Format<TUnit>(
            double value,
            TUnit unit,
            UnitConverterUnitFormat unitFormat)
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
            UnitConverterUnitFormat unitFormat)
            where TUnit : struct
        {
            UnitConverterFamilyDescriptor<TUnit> family;
            if (!UnitConverterCatalog.TryGetFamily(out family))
            {
                throw new NotSupportedException(
                    "No unit family descriptor is registered for " + typeof(TUnit).FullName + ".");
            }

            UnitConverterUnitDescriptor descriptor = family.GetUnit(unit);
            string unitText;

            switch (unitFormat)
            {
                case UnitConverterUnitFormat.Symbol:
                    unitText = descriptor.Symbol;
                    break;
                case UnitConverterUnitFormat.DisplayName:
                    unitText = UnitConverterLocalization.GetDisplayName(
                        unit,
                        formatProvider ?? CultureInfo.InvariantCulture,
                        descriptor.DisplayName);
                    break;
                case UnitConverterUnitFormat.EnumName:
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