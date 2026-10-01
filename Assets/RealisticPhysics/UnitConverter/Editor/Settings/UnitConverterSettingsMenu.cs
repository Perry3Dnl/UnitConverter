namespace RealisticPhysics.UnitConversion.Editor.Settings
{
    using RealisticPhysics.Core.Editor.Settings;
    using UnityEditor;

    public static class UnitConverterSettingsMenu
    {
        [MenuItem("Tools/RealisticPhysics/UnitConverter/Open Settings")]
        public static void OpenSettings()
        {
            UnitConverterSettingsLocator.OpenSettings();
        }

        [MenuItem("Tools/RealisticPhysics/UnitConverter/Reset Settings To Recommended Defaults")]
        public static void ResetSettings()
        {
            UnitConverterSettings settings = UnitConverterSettingsLocator.GetOrCreateSettings();
            Undo.RecordObject(settings, "Reset UnitConverter Settings");
            settings.ResetToRecommendedDefaults();
            EditorUtility.SetDirty(settings);
            AssetDatabase.SaveAssets();
            RealisticPhysicsSettingsUtility.SelectAndPing(settings);
        }
    }
}
