namespace UnitConverter.Catalog
{
    using System;

    /// <summary>
    /// Provides runtime metadata and lookup helpers for all registered unit families.
    /// </summary>
    public static partial class UnitConverterCatalog
    {
        /// <summary>
        /// Returns the stable catalog names of all registered unit families.
        /// </summary>
        public static string[] GetFamilyNames()
        {
            UnitConverterFamilyDescriptor[] families = GetFamilies();
            var names = new string[families.Length];

            for (int index = 0; index < families.Length; index++)
            {
                names[index] = families[index].Name;
            }

            return names;
        }

        /// <summary>
        /// Gets a family descriptor by its stable catalog name.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="familyName"/> is empty or is not a registered family name.
        /// </exception>
        public static UnitConverterFamilyDescriptor GetFamily(string familyName)
        {
            UnitConverterFamilyDescriptor descriptor;
            if (!TryGetFamily(familyName, out descriptor))
            {
                throw new ArgumentException(
                    "The unit family '" + familyName + "' is not registered.",
                    nameof(familyName));
            }

            return descriptor;
        }

        /// <summary>
        /// Gets the family descriptor associated with a catalog unit enum type.
        /// </summary>
        /// <typeparam name="TUnit">The unit enum type.</typeparam>
        /// <exception cref="NotSupportedException">
        /// Thrown when the unit type is not registered in the catalog.
        /// </exception>
        public static UnitConverterFamilyDescriptor<TUnit> GetFamily<TUnit>()
            where TUnit : struct
        {
            UnitConverterFamilyDescriptor<TUnit> descriptor;
            if (!TryGetFamily(out descriptor))
            {
                throw new NotSupportedException(
                    "No unit family descriptor is registered for " +
                    typeof(TUnit).FullName + ".");
            }

            return descriptor;
        }

        /// <summary>
        /// Gets the stable name of the base unit for a family name, or an empty string when the family is unknown.
        /// </summary>
        public static string GetBaseUnitName(string familyName)
        {
            UnitConverterFamilyDescriptor descriptor;
            return TryGetFamily(familyName, out descriptor)
                ? descriptor.BaseUnitName
                : string.Empty;
        }

        /// <summary>
        /// Gets the stable name of the base unit for a registered family.
        /// </summary>
        public static string GetBaseUnitName(UnitConverterFamily family)
        {
            return GetFamily(family).BaseUnitName;
        }

        /// <summary>
        /// Attempts to get the stable base-unit name for a family name.
        /// </summary>
        public static bool TryGetBaseUnitName(string familyName, out string baseUnitName)
        {
            UnitConverterFamilyDescriptor descriptor;
            if (TryGetFamily(familyName, out descriptor))
            {
                baseUnitName = descriptor.BaseUnitName;
                return true;
            }

            baseUnitName = string.Empty;
            return false;
        }

        /// <summary>
        /// Attempts to get the stable base-unit name for a family.
        /// </summary>
        public static bool TryGetBaseUnitName(
            UnitConverterFamily family,
            out string baseUnitName)
        {
            UnitConverterFamilyDescriptor descriptor;
            if (TryGetFamily(family, out descriptor))
            {
                baseUnitName = descriptor.BaseUnitName;
                return true;
            }

            baseUnitName = string.Empty;
            return false;
        }
    }
}
