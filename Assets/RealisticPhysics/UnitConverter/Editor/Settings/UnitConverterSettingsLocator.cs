namespace RealisticPhysics.UnitConversion.Editor.Settings
{
    using RealisticPhysics.Core.Editor.Settings;

    public static class UnitConverterSettingsLocator
    {
        public const string SettingsFolder = "Assets/RealisticPhysics/UnitConverter/Settings";
        public const string SettingsFileName = "UnitConverterSettings";

        public static UnitConverterSettings GetOrCreateSettings()
        {
            return RealisticPhysicsSettingsUtility.FindOrCreateSettings<UnitConverterSettings>(
                SettingsFolder,
                SettingsFileName);
        }

        public static UnitConverterSettings FindSettings()
        {
            return RealisticPhysicsSettingsUtility.FindSettings<UnitConverterSettings>();
        }

        public static void OpenSettings()
        {
            UnitConverterSettings settings = GetOrCreateSettings();
            RealisticPhysicsSettingsUtility.SelectAndPing(settings);
        }
    }
}
