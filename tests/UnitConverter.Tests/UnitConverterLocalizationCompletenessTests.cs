namespace UnitConverter.Tests
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using NUnit.Framework;
    using UnitConverter.Catalog;

    public sealed class UnitConverterLocalizationCompletenessTests
    {
        private static readonly CultureInfo Dutch = CultureInfo.GetCultureInfo("nl-NL");
        private static readonly string[] CompleteDutchFamilies =
        {
            "Angle",
            "Force",
            "Frequency",
            "Power",
            "Speed",
            "Temperature",
            "Time",
        };

        [Test]
        public void CompleteDutchFamilies_HaveRuntimeDisplayNamesForEveryUnit()
        {
            MethodInfo openTryGet = typeof(UnitConverterLocalization)
                .GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Single(method =>
                    method.Name == "TryGetDisplayName" &&
                    method.IsGenericMethodDefinition);

            foreach (string familyName in CompleteDutchFamilies)
            {
                UnitConverterFamilyDescriptor family = UnitConverterCatalog.GetFamily(familyName);
                MethodInfo tryGet = openTryGet.MakeGenericMethod(family.UnitType);

                foreach (UnitConverterUnitDescriptor unit in family.Units)
                {
                    object[] args = { unit.Unit, Dutch, null };
                    bool found = (bool)tryGet.Invoke(null, args);
                    string displayName = (string)args[2];

                    Assert.That(found, Is.True, family.Name + "." + unit.Name);
                    Assert.That(displayName, Is.Not.Null.And.Not.Empty, family.Name + "." + unit.Name);
                }
            }
        }

        [Test]
        public void CompleteDutchFamilies_DisplayNamesRoundTripThroughDynamicConversion()
        {
            MethodInfo openTryGet = typeof(UnitConverterLocalization)
                .GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Single(method =>
                    method.Name == "TryGetDisplayName" &&
                    method.IsGenericMethodDefinition);

            foreach (string familyName in CompleteDutchFamilies)
            {
                UnitConverterFamilyDescriptor family = UnitConverterCatalog.GetFamily(familyName);
                MethodInfo tryGet = openTryGet.MakeGenericMethod(family.UnitType);

                foreach (UnitConverterUnitDescriptor unit in family.Units)
                {
                    object[] args = { unit.Unit, Dutch, null };
                    Assert.That((bool)tryGet.Invoke(null, args), Is.True);
                    string displayName = (string)args[2];

                    UnitConverterDynamicResult result = UnitConverterDynamic.TryConvert(
                        1d,
                        family.Family,
                        displayName,
                        family.BaseUnitName,
                        Dutch);

                    Assert.That(
                        result.Success,
                        Is.True,
                        family.Name + "." + unit.Name + " localized display name '" + displayName + "'");
                }
            }
        }
    }
}
