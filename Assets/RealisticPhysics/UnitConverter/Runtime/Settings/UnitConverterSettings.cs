namespace RealisticPhysics.UnitConversion
{
    using RealisticPhysics.Core.Settings;
    using RealisticPhysics.UnitConversion.Angle;
    using RealisticPhysics.UnitConversion.Length;
    using RealisticPhysics.UnitConversion.Mass;
    using UnityEngine;

    [CreateAssetMenu(
        menuName = "RealisticPhysics/Unit Converter/Settings",
        fileName = "UnitConverterSettings")]
    public sealed class UnitConverterSettings : RealisticPhysicsSettingsAsset
    {
        [Header("Master Switch")]
        [SerializeField] private bool enableUnityInspectorOverrides = true;

        [Header("Inspector Overrides")]
        [SerializeField] private bool overrideTransformInspector = true;
        [SerializeField] private bool overrideRigidbodyInspector = false;
        [SerializeField] private bool overrideColliderInspectors = false;
        [SerializeField] private bool overrideCharacterControllerInspector = false;
        [SerializeField] private bool overrideCameraInspector = false;
        [SerializeField] private bool overrideLightInspector = false;
        [SerializeField] private bool overrideAudioSourceInspector = false;

        [Header("Transform")]
        [SerializeField] private UnitConverterLengthUnit transformPositionUnit = UnitConverterLengthUnit.Meter;
        [SerializeField] private UnitConverterAngleUnit transformRotationUnit = UnitConverterAngleUnit.Degree;
        [SerializeField] private bool showTransformScaleAsDefaultUnityScale = true;

        [Header("Rigidbody")]
        [SerializeField] private UnitConverterMassUnit rigidbodyMassUnit = UnitConverterMassUnit.Kilogram;

        [Header("Colliders")]
        [SerializeField] private UnitConverterLengthUnit colliderLengthUnit = UnitConverterLengthUnit.Meter;
        [SerializeField] private UnitConverterLengthUnit characterControllerLengthUnit = UnitConverterLengthUnit.Meter;
        [SerializeField] private UnitConverterAngleUnit characterControllerSlopeAngleUnit = UnitConverterAngleUnit.Degree;

        [Header("Camera")]
        [SerializeField] private UnitConverterLengthUnit cameraClipPlaneUnit = UnitConverterLengthUnit.Meter;
        [SerializeField] private UnitConverterAngleUnit cameraFieldOfViewUnit = UnitConverterAngleUnit.Degree;

        [Header("Light")]
        [SerializeField] private UnitConverterLengthUnit lightRangeUnit = UnitConverterLengthUnit.Meter;

        [Header("Audio")]
        [SerializeField] private UnitConverterLengthUnit audioDistanceUnit = UnitConverterLengthUnit.Meter;

        [Header("Debug")]
        [SerializeField] private bool showNativeUnityValues = false;

        public override string ModuleId => "com.realisticphysics.unitconverter";

        public bool EnableUnityInspectorOverrides => enableUnityInspectorOverrides;
        public bool OverrideTransformInspector => overrideTransformInspector;
        public bool OverrideRigidbodyInspector => overrideRigidbodyInspector;
        public bool OverrideColliderInspectors => overrideColliderInspectors;
        public bool OverrideCharacterControllerInspector => overrideCharacterControllerInspector;
        public bool OverrideCameraInspector => overrideCameraInspector;
        public bool OverrideLightInspector => overrideLightInspector;
        public bool OverrideAudioSourceInspector => overrideAudioSourceInspector;

        public UnitConverterLengthUnit TransformPositionUnit => transformPositionUnit;
        public UnitConverterAngleUnit TransformRotationUnit => transformRotationUnit;
        public bool ShowTransformScaleAsDefaultUnityScale => showTransformScaleAsDefaultUnityScale;

        public UnitConverterMassUnit RigidbodyMassUnit => rigidbodyMassUnit;
        public UnitConverterLengthUnit ColliderLengthUnit => colliderLengthUnit;
        public UnitConverterLengthUnit CharacterControllerLengthUnit => characterControllerLengthUnit;
        public UnitConverterAngleUnit CharacterControllerSlopeAngleUnit => characterControllerSlopeAngleUnit;
        public UnitConverterLengthUnit CameraClipPlaneUnit => cameraClipPlaneUnit;
        public UnitConverterAngleUnit CameraFieldOfViewUnit => cameraFieldOfViewUnit;
        public UnitConverterLengthUnit LightRangeUnit => lightRangeUnit;
        public UnitConverterLengthUnit AudioDistanceUnit => audioDistanceUnit;
        public bool ShowNativeUnityValues => showNativeUnityValues;

        public override void ResetToRecommendedDefaults()
        {
            enableUnityInspectorOverrides = true;

            overrideTransformInspector = true;
            overrideRigidbodyInspector = false;
            overrideColliderInspectors = false;
            overrideCharacterControllerInspector = false;
            overrideCameraInspector = false;
            overrideLightInspector = false;
            overrideAudioSourceInspector = false;

            transformPositionUnit = UnitConverterLengthUnit.Meter;
            transformRotationUnit = UnitConverterAngleUnit.Degree;
            showTransformScaleAsDefaultUnityScale = true;

            rigidbodyMassUnit = UnitConverterMassUnit.Kilogram;
            colliderLengthUnit = UnitConverterLengthUnit.Meter;
            characterControllerLengthUnit = UnitConverterLengthUnit.Meter;
            characterControllerSlopeAngleUnit = UnitConverterAngleUnit.Degree;
            cameraClipPlaneUnit = UnitConverterLengthUnit.Meter;
            cameraFieldOfViewUnit = UnitConverterAngleUnit.Degree;
            lightRangeUnit = UnitConverterLengthUnit.Meter;
            audioDistanceUnit = UnitConverterLengthUnit.Meter;
            showNativeUnityValues = false;
        }
    }
}
