namespace RealisticPhysics.UnitConversion.Editor.Inspectors
{
    using RealisticPhysics.UnitConversion.Editor.Drawing;
    using RealisticPhysics.UnitConversion.Editor.Settings;
    using UnityEditor;
    using UnityEngine;

    [CustomEditor(typeof(CharacterController))]
    [CanEditMultipleObjects]
    public sealed class UnitConverterCharacterControllerEditor : UnityEditor.Editor
    {
        private SerializedProperty center;
        private SerializedProperty radius;
        private SerializedProperty height;
        private SerializedProperty slopeLimit;
        private SerializedProperty stepOffset;
        private SerializedProperty skinWidth;
        private SerializedProperty minMoveDistance;

        private void OnEnable()
        {
            center = serializedObject.FindProperty("m_Center");
            radius = serializedObject.FindProperty("m_Radius");
            height = serializedObject.FindProperty("m_Height");
            slopeLimit = serializedObject.FindProperty("m_SlopeLimit");
            stepOffset = serializedObject.FindProperty("m_StepOffset");
            skinWidth = serializedObject.FindProperty("m_SkinWidth");
            minMoveDistance = serializedObject.FindProperty("m_MinMoveDistance");
        }

        public override void OnInspectorGUI()
        {
            UnitConverterSettings settings = UnitConverterSettingsLocator.GetOrCreateSettings();

            if (settings == null || !settings.EnableUnityInspectorOverrides || !settings.OverrideCharacterControllerInspector)
            {
                DrawDefaultInspector();
                return;
            }

            serializedObject.Update();
            EditorGUILayout.LabelField("UnitConverter Character Controller", EditorStyles.boldLabel);
            DrawPropertiesExcluding(serializedObject, "m_Center", "m_Radius", "m_Height", "m_SlopeLimit", "m_StepOffset", "m_SkinWidth", "m_MinMoveDistance");

            if (center != null) center.vector3Value = UnitConverterEditorFields.LengthVector3Field("Center", center.vector3Value, settings.CharacterControllerLengthUnit);
            if (radius != null) radius.floatValue = UnitConverterEditorFields.LengthField("Radius", radius.floatValue, settings.CharacterControllerLengthUnit);
            if (height != null) height.floatValue = UnitConverterEditorFields.LengthField("Height", height.floatValue, settings.CharacterControllerLengthUnit);
            if (slopeLimit != null) slopeLimit.floatValue = UnitConverterEditorFields.AngleField("Slope Limit", slopeLimit.floatValue, settings.CharacterControllerSlopeAngleUnit);
            if (stepOffset != null) stepOffset.floatValue = UnitConverterEditorFields.LengthField("Step Offset", stepOffset.floatValue, settings.CharacterControllerLengthUnit);
            if (skinWidth != null) skinWidth.floatValue = UnitConverterEditorFields.LengthField("Skin Width", skinWidth.floatValue, settings.CharacterControllerLengthUnit);
            if (minMoveDistance != null) minMoveDistance.floatValue = UnitConverterEditorFields.LengthField("Min Move Distance", minMoveDistance.floatValue, settings.CharacterControllerLengthUnit);

            serializedObject.ApplyModifiedProperties();
        }
    }
}
