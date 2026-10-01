namespace RealisticPhysics.UnitConversion.Editor.Inspectors
{
    using RealisticPhysics.UnitConversion.Editor.Drawing;
    using RealisticPhysics.UnitConversion.Editor.Settings;
    using UnityEditor;
    using UnityEngine;

    [CustomEditor(typeof(BoxCollider))]
    [CanEditMultipleObjects]
    public sealed class UnitConverterBoxColliderEditor : UnityEditor.Editor
    {
        private SerializedProperty center;
        private SerializedProperty size;

        private void OnEnable()
        {
            center = serializedObject.FindProperty("m_Center");
            size = serializedObject.FindProperty("m_Size");
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
            EditorGUILayout.LabelField("UnitConverter Box Collider", EditorStyles.boldLabel);
            DrawPropertiesExcluding(serializedObject, "m_Center", "m_Size");

            if (center != null)
            {
                center.vector3Value = UnitConverterEditorFields.LengthVector3Field("Center", center.vector3Value, settings.ColliderLengthUnit);
            }

            if (size != null)
            {
                size.vector3Value = UnitConverterEditorFields.LengthVector3Field("Size", size.vector3Value, settings.ColliderLengthUnit);
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}
