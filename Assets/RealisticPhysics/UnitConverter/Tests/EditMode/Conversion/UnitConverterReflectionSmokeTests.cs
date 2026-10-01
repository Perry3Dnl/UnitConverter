namespace RealisticPhysics.UnitConversion.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.Length;

    public sealed class UnitConverterReflectionSmokeTests
    {
        [Test]
        public void AllConverterFamilies_HaveSelfConversionsThatReturnTheInputValue()
        {
            int testedConversions = 0;
            double input = 123.456789d;

            foreach (MethodInfo convertMethod in GetConverterMethods())
            {
                Type unitType = convertMethod.GetParameters()[1].ParameterType;
                Array units = Enum.GetValues(unitType);

                foreach (object unit in units)
                {
                    double result = (double)convertMethod.Invoke(
                        null,
                        new[] { input, unit, unit });

                    RealisticPhysicsTestAssert.AreApproximatelyEqual(
                        input,
                        result,
                        absoluteTolerance: 0.000001d,
                        relativeTolerance: 0.000001d);

                    testedConversions++;
                }
            }

            Assert.Greater(testedConversions, 250, "Expected a broad unit coverage smoke test.");
        }

        [Test]
        public void AllConverterFamilies_CanRoundTripBetweenUnits()
        {
            int testedRoundTrips = 0;
            double input = 12.3456789d;

            foreach (MethodInfo convertMethod in GetConverterMethods())
            {
                Type unitType = convertMethod.GetParameters()[1].ParameterType;
                Array units = Enum.GetValues(unitType);

                foreach (object from in units)
                {
                    foreach (object to in units)
                    {
                        double converted = (double)convertMethod.Invoke(
                            null,
                            new[] { input, from, to });

                        double roundTrip = (double)convertMethod.Invoke(
                            null,
                            new[] { converted, to, from });

                        RealisticPhysicsTestAssert.AreApproximatelyEqual(
                            input,
                            roundTrip,
                            absoluteTolerance: 0.00001d,
                            relativeTolerance: 0.00001d);

                        testedRoundTrips++;
                    }
                }
            }

            Assert.Greater(testedRoundTrips, 5000, "Expected thousands of compatible conversion round-trip checks.");
        }

        private static MethodInfo[] GetConverterMethods()
        {
            Assembly assembly = typeof(UnitConverterLength).Assembly;

            return assembly.GetTypes()
                .Where(type => type.IsClass && type.IsAbstract && type.IsSealed)
                .Where(type => type.Name.StartsWith("UnitConverter", StringComparison.Ordinal))
                .Where(type => !type.Name.EndsWith("Extensions", StringComparison.Ordinal))
                .SelectMany(type => type.GetMethods(BindingFlags.Public | BindingFlags.Static))
                .Where(method => method.Name == "Convert")
                .Where(HasExpectedConvertSignature)
                .OrderBy(method => method.DeclaringType.FullName)
                .ToArray();
        }

        private static bool HasExpectedConvertSignature(MethodInfo method)
        {
            ParameterInfo[] parameters = method.GetParameters();

            return method.ReturnType == typeof(double)
                   && parameters.Length == 3
                   && parameters[0].ParameterType == typeof(double)
                   && parameters[1].ParameterType.IsEnum
                   && parameters[1].ParameterType == parameters[2].ParameterType;
        }
    }
}
