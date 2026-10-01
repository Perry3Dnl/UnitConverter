namespace RealisticPhysics.UnitConversion.Editor.Inspectors
{
    using RealisticPhysics.UnitConversion.Editor.Drawing;
    using RealisticPhysics.UnitConversion.Editor.Settings;
    using UnityEditor;
    using UnityEngine;

    [CustomEditor(typeof(CapsuleCollider))]
    [CanEditMultipleObjects]
    public sealed class UnitConverterCapsuleColliderEditor : UnityEditor.Editor
    {
        private SerializedProperty center;
        private SerializedProperty radius;
        private SerializedProperty height;

        private void OnEnable()
        {
            center = serializedObject.FindProperty("m_Center");
            radius = serializedObject.FindProperty("m_Radius");
            height = serializedObject.FindProperty("m_Height");
        }

        public override void OnInspectorGUI()
        {
            UnitConverterSettings settings = UnitConverterSettingsLocator.GetOrCreateSettings();

            if (settings == null || !settings.EnableUnityInspectorOverrides || !settings.OverrideColliderInspectors)
            {
                DrawDefaultInspector();
                return;
            }

            serializedObject.Update();
            EditorGUILayout.LabelField("UnitConverter Capsule Collider", EditorStyles.boldLabel);
            DrawPropertiesExcluding(serializedObject, "m_Center", "m_Radius", "m_Height");

            if (center != null)
            {
                center.vector3Value = UnitConverterEditorFields.LengthVector3Field("Center", center.vector3Value, settings.ColliderLengthUnit);
            }

            if (radius != null)
            {
                radius.floatValue = UnitConverterEditorFields.LengthField("Radius", radius.floatValue, settings.ColliderLengthUnit);
            }

            if (height != null)
            {
                height.floatValue = UnitConverterEditorFields.LengthField("Height", height.floatValue, settings.ColliderLengthUnit);
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}
