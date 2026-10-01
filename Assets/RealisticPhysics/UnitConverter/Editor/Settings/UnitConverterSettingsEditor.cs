namespace RealisticPhysics.UnitConversion.Editor.Settings
{
    using UnityEditor;
    using UnityEngine;

    [CustomEditor(typeof(UnitConverterSettings))]
    public sealed class UnitConverterSettingsEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.HelpBox(
                "UnitConverter settings control which Unity built-in inspectors are enhanced and which units they display. Unity still stores native values internally.",
                MessageType.Info);

            DrawDefaultInspector();

            EditorGUILayout.Space(8);

            if (GUILayout.Button("Reset To Recommended Defaults"))
            {
                foreach (Object selectedTarget in targets)
                {
                    UnitConverterSettings settings = selectedTarget as UnitConverterSettings;
                    if (settings == null)
                    {
                        continue;
                    }

                    Undo.RecordObject(settings, "Reset UnitConverter Settings");
                    settings.ResetToRecommendedDefaults();
                    EditorUtility.SetDirty(settings);
                }

                AssetDatabase.SaveAssets();
            }
        }
    }
}
