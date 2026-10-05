namespace UnitConverter.Catalog
{
    public static partial class UnitConverterCatalog
    {
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

        public static string GetBaseUnitName(string familyName)
        {
            UnitConverterFamilyDescriptor descriptor;
            return TryGetFamily(familyName, out descriptor)
                ? descriptor.BaseUnitName
                : string.Empty;
        }

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
    }
}
