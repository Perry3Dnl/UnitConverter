namespace RealisticPhysics.UnitConversion.Editor.Inspectors
{
    using RealisticPhysics.UnitConversion.Editor.Drawing;
    using RealisticPhysics.UnitConversion.Editor.Settings;
    using UnityEditor;
    using UnityEngine;

    [CustomEditor(typeof(AudioSource))]
    [CanEditMultipleObjects]
    public sealed class UnitConverterAudioSourceEditor : UnityEditor.Editor
    {
        private SerializedProperty minDistance;
        private SerializedProperty maxDistance;

        private void OnEnable()
        {
            minDistance = serializedObject.FindProperty("MinDistance") ?? serializedObject.FindProperty("m_MinDistance");
            maxDistance = serializedObject.FindProperty("MaxDistance") ?? serializedObject.FindProperty("m_MaxDistance");
        }

        public override void OnInspectorGUI()
        {
            UnitConverterSettings settings = UnitConverterSettingsLocator.GetOrCreateSettings();

            if (settings == null || !settings.EnableUnityInspectorOverrides || !settings.OverrideAudioSourceInspector)
            {
                DrawDefaultInspector();
                return;
            }

            serializedObject.Update();
            EditorGUILayout.LabelField("UnitConverter Audio Source", EditorStyles.boldLabel);
            DrawPropertiesExcluding(serializedObject, "MinDistance", "MaxDistance", "m_MinDistance", "m_MaxDistance");

            if (minDistance != null) minDistance.floatValue = UnitConverterEditorFields.LengthField("Min Distance", minDistance.floatValue, settings.AudioDistanceUnit);
            if (maxDistance != null) maxDistance.floatValue = UnitConverterEditorFields.LengthField("Max Distance", maxDistance.floatValue, settings.AudioDistanceUnit);

            serializedObject.ApplyModifiedProperties();
        }
    }
}
