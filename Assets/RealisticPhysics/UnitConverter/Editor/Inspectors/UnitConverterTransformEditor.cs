namespace RealisticPhysics.UnitConversion.Editor.Inspectors
{
    using RealisticPhysics.UnitConversion.Editor.Drawing;
    using RealisticPhysics.UnitConversion.Editor.Settings;
    using UnityEditor;
    using UnityEngine;

    [CustomEditor(typeof(Transform))]
    [CanEditMultipleObjects]
    public sealed class UnitConverterTransformEditor : UnityEditor.Editor
    {
        private SerializedProperty localPosition;
        private SerializedProperty localEulerAnglesHint;
        private SerializedProperty localScale;

        private void OnEnable()
        {
            localPosition = serializedObject.FindProperty("m_LocalPosition");
            localEulerAnglesHint = serializedObject.FindProperty("m_LocalEulerAnglesHint");
            localScale = serializedObject.FindProperty("m_LocalScale");
        }

        public override void OnInspectorGUI()
        {
            UnitConverterSettings settings = UnitConverterSettingsLocator.GetOrCreateSettings();

            if (settings == null || !settings.EnableUnityInspectorOverrides || !settings.OverrideTransformInspector)
            {
                DrawDefaultInspector();
                return;
            }

            serializedObject.Update();
            EditorGUILayout.LabelField("UnitConverter Transform", EditorStyles.boldLabel);

            if (localPosition != null)
            {
                Vector3 currentValue = localPosition.vector3Value;
                localPosition.vector3Value = UnitConverterEditorFields.LengthVector3Field("Position", currentValue, settings.TransformPositionUnit);
                UnitConverterEditorFields.NativeValueLabel("Position", currentValue.ToString("F4"), settings.ShowNativeUnityValues);
            }

            if (localEulerAnglesHint != null)
            {
                Vector3 currentValue = localEulerAnglesHint.vector3Value;
                localEulerAnglesHint.vector3Value = UnitConverterEditorFields.AngleVector3Field("Rotation", currentValue, settings.TransformRotationUnit);
                UnitConverterEditorFields.NativeValueLabel("Rotation", currentValue.ToString("F4"), settings.ShowNativeUnityValues);
            }

            if (localScale != null)
            {
                EditorGUILayout.PropertyField(localScale, new GUIContent("Scale"));
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}
