namespace RealisticPhysics.UnitConversion.Editor.Inspectors
{
    using RealisticPhysics.UnitConversion.Editor.Drawing;
    using RealisticPhysics.UnitConversion.Editor.Settings;
    using UnityEditor;
    using UnityEngine;

    [CustomEditor(typeof(Light))]
    [CanEditMultipleObjects]
    public sealed class UnitConverterLightEditor : UnityEditor.Editor
    {
        private SerializedProperty range;

        private void OnEnable()
        {
            range = serializedObject.FindProperty("m_Range");
        }

        public override void OnInspectorGUI()
        {
            UnitConverterSettings settings = UnitConverterSettingsLocator.GetOrCreateSettings();

            if (settings == null || !settings.EnableUnityInspectorOverrides || !settings.OverrideLightInspector)
            {
                DrawDefaultInspector();
                return;
            }

            serializedObject.Update();
            EditorGUILayout.LabelField("UnitConverter Light", EditorStyles.boldLabel);
            DrawPropertiesExcluding(serializedObject, "m_Range");

            if (range != null)
            {
                range.floatValue = UnitConverterEditorFields.LengthField("Range", range.floatValue, settings.LightRangeUnit);
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}
