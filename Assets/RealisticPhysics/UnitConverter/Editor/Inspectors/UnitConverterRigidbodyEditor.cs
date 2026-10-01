namespace RealisticPhysics.UnitConversion.Editor.Inspectors
{
    using RealisticPhysics.UnitConversion.Editor.Drawing;
    using RealisticPhysics.UnitConversion.Editor.Settings;
    using UnityEditor;
    using UnityEngine;

    [CustomEditor(typeof(Rigidbody))]
    [CanEditMultipleObjects]
    public sealed class UnitConverterRigidbodyEditor : UnityEditor.Editor
    {
        private SerializedProperty mass;

        private void OnEnable()
        {
            mass = serializedObject.FindProperty("m_Mass");
        }

        public override void OnInspectorGUI()
        {
            UnitConverterSettings settings = UnitConverterSettingsLocator.GetOrCreateSettings();

            if (settings == null || !settings.EnableUnityInspectorOverrides || !settings.OverrideRigidbodyInspector)
            {
                DrawDefaultInspector();
                return;
            }

            serializedObject.Update();
            EditorGUILayout.LabelField("UnitConverter Rigidbody", EditorStyles.boldLabel);

            if (mass != null)
            {
                float currentValue = mass.floatValue;
                mass.floatValue = UnitConverterEditorFields.MassField("Mass", currentValue, settings.RigidbodyMassUnit);
                UnitConverterEditorFields.NativeValueLabel("Mass", currentValue.ToString("F4") + " kg", settings.ShowNativeUnityValues);
            }

            DrawPropertiesExcluding(serializedObject, "m_Mass");
            serializedObject.ApplyModifiedProperties();
        }
    }
}
