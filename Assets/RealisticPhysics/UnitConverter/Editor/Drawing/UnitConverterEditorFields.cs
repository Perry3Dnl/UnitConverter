namespace RealisticPhysics.UnitConversion.Editor.Drawing
{
    using RealisticPhysics.UnitConversion.Angle;
    using RealisticPhysics.UnitConversion.Length;
    using RealisticPhysics.UnitConversion.Mass;
    using UnityEditor;
    using UnityEngine;

    public static class UnitConverterEditorFields
    {
        public static float LengthField(string label, float unityMeters, UnitConverterLengthUnit displayUnit)
        {
            double displayValue = UnitConverterLength.FromMeter(unityMeters, displayUnit);
            string symbol = UnitConverterLength.GetSymbol(displayUnit);

            EditorGUI.BeginChangeCheck();
            double editedDisplayValue = EditorGUILayout.DoubleField($"{label} ({symbol})", displayValue);

            if (EditorGUI.EndChangeCheck())
            {
                return (float)UnitConverterLength.ToMeter(editedDisplayValue, displayUnit);
            }

            return unityMeters;
        }

        public static Vector3 LengthVector3Field(string label, Vector3 unityMeters, UnitConverterLengthUnit displayUnit)
        {
            string symbol = UnitConverterLength.GetSymbol(displayUnit);
            Vector3 displayValue = new Vector3(
                (float)UnitConverterLength.FromMeter(unityMeters.x, displayUnit),
                (float)UnitConverterLength.FromMeter(unityMeters.y, displayUnit),
                (float)UnitConverterLength.FromMeter(unityMeters.z, displayUnit));

            EditorGUI.BeginChangeCheck();
            Vector3 editedDisplayValue = EditorGUILayout.Vector3Field($"{label} ({symbol})", displayValue);

            if (EditorGUI.EndChangeCheck())
            {
                return new Vector3(
                    (float)UnitConverterLength.ToMeter(editedDisplayValue.x, displayUnit),
                    (float)UnitConverterLength.ToMeter(editedDisplayValue.y, displayUnit),
                    (float)UnitConverterLength.ToMeter(editedDisplayValue.z, displayUnit));
            }

            return unityMeters;
        }

        public static float MassField(string label, float unityKilograms, UnitConverterMassUnit displayUnit)
        {
            double displayValue = UnitConverterMass.FromKilogram(unityKilograms, displayUnit);
            string symbol = UnitConverterMass.GetSymbol(displayUnit);

            EditorGUI.BeginChangeCheck();
            double editedDisplayValue = EditorGUILayout.DoubleField($"{label} ({symbol})", displayValue);

            if (EditorGUI.EndChangeCheck())
            {
                return (float)UnitConverterMass.ToKilogram(editedDisplayValue, displayUnit);
            }

            return unityKilograms;
        }

        public static float AngleField(string label, float unityDegrees, UnitConverterAngleUnit displayUnit)
        {
            double displayValue = UnitConverterAngle.FromDegree(unityDegrees, displayUnit);
            string symbol = UnitConverterAngle.GetSymbol(displayUnit);

            EditorGUI.BeginChangeCheck();
            double editedDisplayValue = EditorGUILayout.DoubleField($"{label} ({symbol})", displayValue);

            if (EditorGUI.EndChangeCheck())
            {
                return (float)UnitConverterAngle.ToDegree(editedDisplayValue, displayUnit);
            }

            return unityDegrees;
        }

        public static Vector3 AngleVector3Field(string label, Vector3 unityDegrees, UnitConverterAngleUnit displayUnit)
        {
            string symbol = UnitConverterAngle.GetSymbol(displayUnit);
            Vector3 displayValue = new Vector3(
                (float)UnitConverterAngle.FromDegree(unityDegrees.x, displayUnit),
                (float)UnitConverterAngle.FromDegree(unityDegrees.y, displayUnit),
                (float)UnitConverterAngle.FromDegree(unityDegrees.z, displayUnit));

            EditorGUI.BeginChangeCheck();
            Vector3 editedDisplayValue = EditorGUILayout.Vector3Field($"{label} ({symbol})", displayValue);

            if (EditorGUI.EndChangeCheck())
            {
                return new Vector3(
                    (float)UnitConverterAngle.ToDegree(editedDisplayValue.x, displayUnit),
                    (float)UnitConverterAngle.ToDegree(editedDisplayValue.y, displayUnit),
                    (float)UnitConverterAngle.ToDegree(editedDisplayValue.z, displayUnit));
            }

            return unityDegrees;
        }

        public static void NativeValueLabel(string label, string value, bool show)
        {
            if (!show)
            {
                return;
            }

            using (new EditorGUI.DisabledScope(true))
            {
                EditorGUILayout.TextField($"Unity Native {label}", value);
            }
        }
    }
}
