namespace RealisticPhysics.UnitConversion.Editor.Inspectors
{
    using RealisticPhysics.UnitConversion.Editor.Drawing;
    using RealisticPhysics.UnitConversion.Editor.Settings;
    using UnityEditor;
    using UnityEngine;

    [CustomEditor(typeof(Camera))]
    [CanEditMultipleObjects]
    public sealed class UnitConverterCameraEditor : UnityEditor.Editor
    {
        private SerializedProperty nearClipPlane;
        private SerializedProperty farClipPlane;
        private SerializedProperty fieldOfView;

        private void OnEnable()
        {
            nearClipPlane = serializedObject.FindProperty("near clip plane") ?? serializedObject.FindProperty("m_NearClipPlane");
            farClipPlane = serializedObject.FindProperty("far clip plane") ?? serializedObject.FindProperty("m_FarClipPlane");
            fieldOfView = serializedObject.FindProperty("field of view") ?? serializedObject.FindProperty("m_FieldOfView");
        }

        public override void OnInspectorGUI()
        {
            UnitConverterSettings settings = UnitConverterSettingsLocator.GetOrCreateSettings();

            if (settings == null || !settings.EnableUnityInspectorOverrides || !settings.OverrideCameraInspector)
            {
                DrawDefaultInspector();
                return;
            }

            serializedObject.Update();
            EditorGUILayout.LabelField("UnitConverter Camera", EditorStyles.boldLabel);
            DrawPropertiesExcluding(serializedObject, "near clip plane", "far clip plane", "field of view", "m_NearClipPlane", "m_FarClipPlane", "m_FieldOfView");

            if (nearClipPlane != null) nearClipPlane.floatValue = UnitConverterEditorFields.LengthField("Near Clip Plane", nearClipPlane.floatValue, settings.CameraClipPlaneUnit);
            if (farClipPlane != null) farClipPlane.floatValue = UnitConverterEditorFields.LengthField("Far Clip Plane", farClipPlane.floatValue, settings.CameraClipPlaneUnit);
            if (fieldOfView != null) fieldOfView.floatValue = UnitConverterEditorFields.AngleField("Field Of View", fieldOfView.floatValue, settings.CameraFieldOfViewUnit);

            serializedObject.ApplyModifiedProperties();
        }
    }
}
