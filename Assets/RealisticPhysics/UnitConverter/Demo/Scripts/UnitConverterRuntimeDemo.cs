namespace RealisticPhysics.UnitConversion.Demo
{
    using System;
    using System.Globalization;
    using System.Reflection;
    using RealisticPhysics.UnitConversion.Catalog;
    using UnityEngine;

    /// <summary>
    /// Code-generated runtime demo UI for UnitConverter.
    /// This demo intentionally uses only code and does not require image assets, fonts, prefabs, or TextMeshPro.
    /// </summary>
    [DisallowMultipleComponent]
    public sealed class UnitConverterRuntimeDemo : MonoBehaviour
    {
        private const float DesignWidth = 1120f;
        private const float DesignHeight = 720f;

        private readonly string[] tabs =
        {
            "Overview",
            "Runtime API",
            "Conversion Tables",
            "Inspector Integration"
        };

        private readonly string[] familyNames = UnitConverterCatalog.GetFamilyNames();

        private int selectedTab;
        private int selectedFamilyIndex;
        private string inputValueText = "1";
        private Vector2 scroll;
        private Vector2 familyScroll;

        private GUIStyle backgroundStyle;
        private GUIStyle panelStyle;
        private GUIStyle headerStyle;
        private GUIStyle subtitleStyle;
        private GUIStyle tabStyle;
        private GUIStyle activeTabStyle;
        private GUIStyle cardStyle;
        private GUIStyle labelStyle;
        private GUIStyle valueStyle;
        private GUIStyle miniLabelStyle;
        private GUIStyle inputStyle;
        private GUIStyle codeInputStyle;
        private GUIStyle badgeStyle;

        private Texture2D darkTexture;
        private Texture2D panelTexture;
        private Texture2D cardTexture;
        private Texture2D accentTexture;
        private Texture2D activeTabTexture;
        private Texture2D codeTexture;

        private void OnGUI()
        {
            EnsureStyles();
            DrawBackground();

            Rect window = GetCenteredRect();
            GUILayout.BeginArea(window, backgroundStyle);
            DrawHeader();
            DrawTabs();

            if (selectedTab == 2)
            {
                DrawInput();
            }

            scroll = GUILayout.BeginScrollView(scroll, false, true);
            GUILayout.BeginVertical(panelStyle);
            DrawSelectedTab();
            GUILayout.EndVertical();
            GUILayout.EndScrollView();

            GUILayout.EndArea();
        }

        private Rect GetCenteredRect()
        {
            float width = Mathf.Min(Screen.width - 32f, DesignWidth);
            float height = Mathf.Min(Screen.height - 32f, DesignHeight);
            return new Rect((Screen.width - width) * 0.5f, (Screen.height - height) * 0.5f, width, height);
        }

        private void DrawBackground()
        {
            GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), darkTexture, ScaleMode.StretchToFill);

            Color previous = GUI.color;
            GUI.color = new Color(0.0f, 0.75f, 1.0f, 0.08f);

            for (int x = 0; x < Screen.width; x += 64)
            {
                GUI.DrawTexture(new Rect(x, 0f, 1f, Screen.height), accentTexture);
            }

            for (int y = 0; y < Screen.height; y += 64)
            {
                GUI.DrawTexture(new Rect(0f, y, Screen.width, 1f), accentTexture);
            }

            GUI.color = previous;
        }

        private void DrawHeader()
        {
            GUILayout.BeginHorizontal();
            GUILayout.BeginVertical();
            GUILayout.Label("RealisticPhysics", subtitleStyle);
            GUILayout.Label("UnitConverter Runtime Demo", headerStyle);
            GUILayout.Label("Code-generated demo UI using the runtime conversion API.", subtitleStyle);
            GUILayout.EndVertical();

            GUILayout.FlexibleSpace();

            int familyCount = familyNames.Length;
            int unitCount = GetTotalUnitCount();
            int pathCount = GetTotalCompatiblePathCount();

            GUILayout.BeginVertical(badgeStyle, GUILayout.Width(300));
            GUILayout.Label(familyCount.ToString(CultureInfo.InvariantCulture) + " Families", valueStyle);
            GUILayout.Label(unitCount.ToString(CultureInfo.InvariantCulture) + " supported units", miniLabelStyle);
            GUILayout.Label(pathCount.ToString("N0", CultureInfo.InvariantCulture) + "+ compatible paths", miniLabelStyle);
            GUILayout.EndVertical();

            GUILayout.EndHorizontal();
            GUILayout.Space(10);
        }

        private void DrawTabs()
        {
            GUILayout.BeginHorizontal();
            for (int i = 0; i < tabs.Length; i++)
            {
                GUIStyle style = selectedTab == i ? activeTabStyle : tabStyle;
                if (GUILayout.Button(tabs[i], style, GUILayout.Height(38)))
                {
                    selectedTab = i;
                    scroll = Vector2.zero;
                }
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(10);
        }

        private void DrawInput()
        {
            GUILayout.BeginHorizontal(cardStyle);
            GUILayout.Label("Demo Value", labelStyle, GUILayout.Width(120));
            inputValueText = GUILayout.TextField(inputValueText, inputStyle, GUILayout.Width(190));
            GUILayout.Label("Used when showing base-unit conversion examples in the selected family.", miniLabelStyle);
            GUILayout.EndHorizontal();
            GUILayout.Space(10);
        }

        private void DrawSelectedTab()
        {
            switch (selectedTab)
            {
                case 0:
                    DrawOverview();
                    break;
                case 1:
                    DrawRuntimeApi();
                    break;
                case 2:
                    DrawConversionTables();
                    break;
                case 3:
                    DrawInspectorIntegration();
                    break;
                default:
                    DrawOverview();
                    break;
            }
        }

        private void DrawOverview()
        {
            DrawSectionTitle("Overview");
            GUILayout.Label("This runtime demo is generated entirely from code and is included as a quick way to explore the package after import. It shows how UnitConverter is structured, how the settings workflow fits into a project, and how the shipped conversion families are exposed at runtime.", labelStyle);
            GUILayout.Space(10);

            DrawTextCard(
                "What UnitConverter provides",
                "UnitConverter includes a runtime conversion API, organized conversion families, extension methods for common numeric types, direct unit-specific methods, optional Unity inspector integrations, and a settings asset workflow.");

            DrawTextCard(
                "Settings asset workflow",
                "The UnitConverter settings asset stores display preferences and editor integration options in one predictable place. This lets the package be configured at the project level instead of requiring repeated setup on individual GameObjects.");

            DrawTextCard(
                "Runtime usage",
                "The runtime API can be used from gameplay code, custom tools, editor utilities, generated UI, validation scripts, or your own systems. It does not require a scene component just to convert values.");

            DrawTextCard(
                "Editor integration",
                "Optional inspector overrides can display converted values inside familiar Unity component inspectors. The goal is to improve the existing Unity workflow while keeping the original Unity data model intact.");

            DrawTextCard(
                "Conversion coverage",
                "The Conversion Tables tab lists every shipped family and every supported unit in the package. It shows live base-unit conversions so the demo reflects the full delivered table coverage, not only a small sample.");

            DrawTextCard(
                "Testing and validation",
                "The package includes Unity EditMode tests for Core and UnitConverter. The conversion tables are checked with known-value tests, base-unit checks, reverse checks, and round-trip validation.");

            DrawTextCard(
                "No visual asset dependency",
                "This demo UI is generated from a single script. It does not require logo images, textures, prefabs, custom fonts, or TextMeshPro, which keeps the demo easy to inspect and remove if not needed.");

            GUILayout.Space(10);
            DrawCoverageSummary();
        }

        private void DrawRuntimeApi()
        {
            DrawSectionTitle("Runtime API Examples");
            GUILayout.Label("These are the main runtime usage styles available to developers. Each code example is shown in a larger input-style box so it is easier to read, select, and copy while the demo is running.", labelStyle);
            GUILayout.Space(10);

            DrawCodeCard(
                "1. Static converter API",
                "double centimeters = UnitConverterLength.Convert(\n    value,\n    UnitConverterLengthUnit.Meter,\n    UnitConverterLengthUnit.Centimeter);",
                "Use this when you want one clear converter class per unit family.");

            DrawCodeCard(
                "2. Extension method API",
                "double centimeters = value.Convert(\n    UnitConverterLengthUnit.Meter,\n    UnitConverterLengthUnit.Centimeter);",
                "Use this when you prefer readable value-first conversion syntax.");

            DrawCodeCard(
                "3. Direct unit-specific methods",
                "double meters = UnitConverterMetricLength.CentimeterToMeter(value);",
                "Use this when you want explicit direct conversion methods grouped by namespace and unit system.");

            DrawCodeCard(
                "4. Base-unit helper methods",
                "double meters = UnitConverterLength.ToMeter(\n    value,\n    UnitConverterLengthUnit.Foot);",
                "Use this when your own system works around a canonical base unit.");

            DrawCodeCard(
                "5. Base-unit output methods",
                "double feet = UnitConverterLength.FromMeter(\n    meters,\n    UnitConverterLengthUnit.Foot);",
                "Use this when you already have a base-unit value and want to display it in another unit.");

            DrawCodeCard(
                "6. Organized namespaces",
                "using RealisticPhysics.UnitConversion.Length;\nusing RealisticPhysics.UnitConversion.Length.Metric;\nusing RealisticPhysics.UnitConversion.Power;",
                "Import only the conversion families or system-specific direct converters you need.");

            DrawCodeCard(
                "7. Common numeric extension support",
                "float result = floatValue.Convert(fromUnit, toUnit);\ndouble result = doubleValue.Convert(fromUnit, toUnit);\ndecimal result = decimalValue.Convert(fromUnit, toUnit);",
                "Extension methods are available for common numeric value types while still routing through the same tested converter logic.");
        }

        private void DrawInspectorIntegration()
        {
            DrawSectionTitle("Inspector Override Examples");
            GUILayout.Label("These are examples of the optional Unity inspector overrides included with UnitConverter. They display converted values inside familiar Unity component inspectors while Unity continues to store the normal underlying values.", labelStyle);
            GUILayout.Space(8);

            DrawInspectorExample("Transform", "Position", "Unity meters", "cm, mm, ft, in, yd, mi");
            DrawInspectorExample("Rigidbody", "Mass", "kilograms", "g, lb, oz, stone, tons");
            DrawInspectorExample("Box Collider", "Size and center", "meters", "cm, mm, ft, in");
            DrawInspectorExample("Sphere Collider", "Radius and center", "meters", "cm, mm, ft, in");
            DrawInspectorExample("Capsule Collider", "Radius, height, and center", "meters", "cm, mm, ft, in");
            DrawInspectorExample("Character Controller", "Radius, height, and center", "meters", "cm, mm, ft, in");
            DrawInspectorExample("Camera", "Near and far clip planes", "meters", "cm, m, ft, km");
            DrawInspectorExample("Light", "Range", "meters", "cm, m, ft");
            DrawInspectorExample("AudioSource", "Min and max distance", "meters", "cm, m, ft");
        }

        private void DrawConversionTables()
        {
            DrawSectionTitle("Conversion Tables");
            GUILayout.Label("Select a family to view every shipped unit in that table. The list shows live conversions from the family base unit to each supported unit.", labelStyle);
            GUILayout.Space(10);

            GUILayout.BeginHorizontal();

            GUILayout.BeginVertical(cardStyle, GUILayout.Width(285));
            GUILayout.Label("Families", valueStyle);
            familyScroll = GUILayout.BeginScrollView(familyScroll, false, true, GUILayout.Height(390));

            for (int i = 0; i < familyNames.Length; i++)
            {
                string family = familyNames[i];
                int count = GetUnitCount(family);
                GUIStyle style = selectedFamilyIndex == i ? activeTabStyle : tabStyle;

                if (GUILayout.Button(ToDisplayName(family) + "  (" + count.ToString(CultureInfo.InvariantCulture) + ")", style, GUILayout.Height(32)))
                {
                    selectedFamilyIndex = i;
                }
            }

            GUILayout.EndScrollView();
            GUILayout.EndVertical();

            GUILayout.Space(10);

            string selectedFamily = familyNames[Mathf.Clamp(selectedFamilyIndex, 0, familyNames.Length - 1)];
            DrawFamilyTable(selectedFamily);

            GUILayout.EndHorizontal();
        }

        private void DrawCoverageSummary()
        {
            GUILayout.BeginVertical(cardStyle);
            GUILayout.Label("Included conversion coverage", valueStyle);
            GUILayout.Label("The package currently exposes " + familyNames.Length.ToString(CultureInfo.InvariantCulture) + " conversion families, " + GetTotalUnitCount().ToString(CultureInfo.InvariantCulture) + " supported units, and " + GetTotalCompatiblePathCount().ToString("N0", CultureInfo.InvariantCulture) + "+ compatible conversion paths.", labelStyle);
            GUILayout.Space(8);

            int columns = 3;
            int index = 0;

            while (index < familyNames.Length)
            {
                GUILayout.BeginHorizontal();
                for (int c = 0; c < columns && index < familyNames.Length; c++, index++)
                {
                    string family = familyNames[index];
                    int units = GetUnitCount(family);
                    GUILayout.Label(ToDisplayName(family) + " · " + units.ToString(CultureInfo.InvariantCulture) + " units", miniLabelStyle, GUILayout.Width(315));
                }
                GUILayout.EndHorizontal();
            }

            GUILayout.EndVertical();
        }

        private void DrawFamilyTable(string family)
        {
            GUILayout.BeginVertical(cardStyle);

            int unitCount = GetUnitCount(family);
            int pathCount = unitCount * unitCount;

            GUILayout.Label(ToDisplayName(family), valueStyle);
            GUILayout.Label(unitCount.ToString(CultureInfo.InvariantCulture) + " units · " + pathCount.ToString("N0", CultureInfo.InvariantCulture) + " compatible paths", miniLabelStyle);
            GUILayout.Space(8);

            Type unitType = GetUnitType(family);
            Type converterType = GetConverterType(family);

            if (unitType == null || converterType == null)
            {
                GUILayout.Label("Unable to load this conversion family.", labelStyle);
                GUILayout.EndVertical();
                return;
            }

            Array units = Enum.GetValues(unitType);
            object baseUnit = GetBaseUnit(family, unitType, units);
            double input = GetInputValue();

            string baseSymbol = GetSymbol(converterType, baseUnit);
            string baseName = ToDisplayName(baseUnit.ToString());

            GUILayout.Label("Base demo: " + FormatNumber(input) + " " + baseSymbol + " (" + baseName + ")", labelStyle);
            GUILayout.Space(6);

            for (int i = 0; i < units.Length; i++)
            {
                object targetUnit = units.GetValue(i);
                DrawFamilyUnitRow(converterType, input, baseUnit, targetUnit);
            }

            GUILayout.EndVertical();
        }

        private void DrawFamilyUnitRow(Type converterType, double input, object baseUnit, object targetUnit)
        {
            string targetName = ToDisplayName(targetUnit.ToString());
            string targetSymbol = GetSymbol(converterType, targetUnit);
            string unitSystem = GetUnitSystem(converterType, targetUnit);

            try
            {
                double output = Convert(converterType, input, baseUnit, targetUnit);

                GUILayout.BeginHorizontal(cardStyle);
                GUILayout.Label(targetName, labelStyle, GUILayout.Width(220));
                GUILayout.Label(string.IsNullOrEmpty(unitSystem) ? "Unit" : unitSystem, miniLabelStyle, GUILayout.Width(135));
                GUILayout.FlexibleSpace();
                GUILayout.Label(FormatNumber(output) + " " + targetSymbol, valueStyle, GUILayout.Width(230));
                GUILayout.EndHorizontal();
            }
            catch (Exception exception)
            {
                GUILayout.BeginHorizontal(cardStyle);
                GUILayout.Label(targetName, labelStyle, GUILayout.Width(220));
                GUILayout.Label("Error", miniLabelStyle, GUILayout.Width(135));
                GUILayout.FlexibleSpace();
                GUILayout.Label(exception.Message, miniLabelStyle, GUILayout.Width(230));
                GUILayout.EndHorizontal();
            }

            GUILayout.Space(4);
        }

        private void DrawCodeCard(string title, string code, string description)
        {
            GUILayout.BeginVertical(cardStyle);
            GUILayout.Label(title, valueStyle);
            GUILayout.TextArea(code, codeInputStyle, GUILayout.MinHeight(78));
            GUILayout.Space(5);
            GUILayout.Label(description, labelStyle);
            GUILayout.EndVertical();
            GUILayout.Space(8);
        }

        private void DrawInspectorExample(string component, string field, string storedValue, string displayUnits)
        {
            GUILayout.BeginHorizontal(cardStyle);
            GUILayout.Label(component, valueStyle, GUILayout.Width(190));
            GUILayout.Label(field, labelStyle, GUILayout.Width(230));
            GUILayout.Label("Stored: " + storedValue, miniLabelStyle, GUILayout.Width(190));
            GUILayout.FlexibleSpace();
            GUILayout.Label("Display: " + displayUnits, miniLabelStyle, GUILayout.Width(255));
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
        }

        private void DrawSectionTitle(string title)
        {
            GUILayout.Label(title, headerStyle);
            GUILayout.Space(8);
        }

        private void DrawTextCard(string title, string description)
        {
            GUILayout.BeginVertical(cardStyle);
            GUILayout.Label(title, valueStyle);
            GUILayout.Label(description, labelStyle);
            GUILayout.EndVertical();
            GUILayout.Space(7);
        }

        private double GetInputValue()
        {
            double value;
            if (double.TryParse(inputValueText, NumberStyles.Float, CultureInfo.InvariantCulture, out value))
            {
                return value;
            }

            return 1d;
        }

        private int GetTotalUnitCount()
        {
            int total = 0;

            for (int i = 0; i < familyNames.Length; i++)
            {
                total += GetUnitCount(familyNames[i]);
            }

            return total;
        }

        private int GetTotalCompatiblePathCount()
        {
            int total = 0;

            for (int i = 0; i < familyNames.Length; i++)
            {
                int count = GetUnitCount(familyNames[i]);
                total += count * count;
            }

            return total;
        }

        private int GetUnitCount(string family)
        {
            Type unitType = GetUnitType(family);
            if (unitType == null)
            {
                return 0;
            }

            return Enum.GetValues(unitType).Length;
        }

        private Type GetUnitType(string family)
        {
            Assembly assembly = typeof(UnitConverterCatalog).Assembly;
            return assembly.GetType("RealisticPhysics.UnitConversion." + family + ".UnitConverter" + family + "Unit");
        }

        private Type GetConverterType(string family)
        {
            Assembly assembly = typeof(UnitConverterCatalog).Assembly;
            return assembly.GetType("RealisticPhysics.UnitConversion." + family + ".UnitConverter" + family);
        }

        private object GetBaseUnit(string family, Type unitType, Array units)
        {
            string baseName = UnitConverterCatalog.GetBaseUnitName(family);

            try
            {
                return Enum.Parse(unitType, baseName);
            }
            catch
            {
                return units.Length > 0 ? units.GetValue(0) : null;
            }
        }

        private double Convert(Type converterType, double value, object from, object to)
        {
            MethodInfo method = converterType.GetMethod(
                "Convert",
                BindingFlags.Public | BindingFlags.Static);

            if (method == null)
            {
                throw new InvalidOperationException("Convert method not found.");
            }

            object result = method.Invoke(null, new[] { (object)value, from, to });
            return System.Convert.ToDouble(result, CultureInfo.InvariantCulture);
        }

        private string GetSymbol(Type converterType, object unit)
        {
            MethodInfo method = converterType.GetMethod(
                "GetSymbol",
                BindingFlags.Public | BindingFlags.Static);

            if (method == null)
            {
                return unit.ToString();
            }

            object result = method.Invoke(null, new[] { unit });
            return result == null ? unit.ToString() : result.ToString();
        }

        private string GetUnitSystem(Type converterType, object unit)
        {
            MethodInfo method = converterType.GetMethod(
                "GetUnitSystem",
                BindingFlags.Public | BindingFlags.Static);

            if (method == null)
            {
                return string.Empty;
            }

            object result = method.Invoke(null, new[] { unit });
            return result == null ? string.Empty : ToDisplayName(result.ToString());
        }

        private static string FormatNumber(double value)
        {
            return value.ToString("0.########", CultureInfo.InvariantCulture);
        }

        private static string ToDisplayName(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            System.Text.StringBuilder builder = new System.Text.StringBuilder(value.Length + 8);
            builder.Append(value[0]);

            for (int i = 1; i < value.Length; i++)
            {
                char current = value[i];
                char previous = value[i - 1];

                if (char.IsUpper(current) && !char.IsUpper(previous))
                {
                    builder.Append(' ');
                }

                builder.Append(current);
            }

            return builder.ToString();
        }

        private void EnsureStyles()
        {
            if (backgroundStyle != null)
            {
                return;
            }

            darkTexture = MakeTexture(new Color(0.015f, 0.025f, 0.045f, 1f));
            panelTexture = MakeTexture(new Color(0.025f, 0.055f, 0.085f, 0.94f));
            cardTexture = MakeTexture(new Color(0.035f, 0.09f, 0.13f, 0.88f));
            accentTexture = MakeTexture(new Color(0.0f, 0.85f, 1.0f, 1f));
            activeTabTexture = MakeTexture(new Color(0.0f, 0.42f, 0.62f, 0.95f));
            codeTexture = MakeTexture(new Color(0.006f, 0.018f, 0.030f, 1f));

            backgroundStyle = new GUIStyle
            {
                padding = new RectOffset(16, 16, 16, 16),
                normal = { background = panelTexture }
            };

            panelStyle = new GUIStyle
            {
                padding = new RectOffset(14, 14, 14, 14),
                normal = { background = panelTexture }
            };

            cardStyle = new GUIStyle
            {
                padding = new RectOffset(12, 12, 10, 10),
                margin = new RectOffset(0, 0, 0, 5),
                normal = { background = cardTexture }
            };

            headerStyle = new GUIStyle(GUI.skin.label)
            {
                fontSize = 31,
                fontStyle = FontStyle.Bold,
                normal = { textColor = new Color(0.92f, 0.98f, 1f, 1f) }
            };

            subtitleStyle = new GUIStyle(GUI.skin.label)
            {
                fontSize = 16,
                normal = { textColor = new Color(0.78f, 0.88f, 0.94f, 1f) }
            };

            labelStyle = new GUIStyle(GUI.skin.label)
            {
                fontSize = 17,
                wordWrap = true,
                normal = { textColor = new Color(0.90f, 0.95f, 1f, 1f) }
            };

            miniLabelStyle = new GUIStyle(GUI.skin.label)
            {
                fontSize = 14,
                wordWrap = true,
                normal = { textColor = new Color(0.78f, 0.86f, 0.92f, 1f) }
            };

            valueStyle = new GUIStyle(GUI.skin.label)
            {
                fontSize = 19,
                fontStyle = FontStyle.Bold,
                wordWrap = true,
                normal = { textColor = new Color(0.94f, 0.98f, 1f, 1f) }
            };

            tabStyle = new GUIStyle(GUI.skin.button)
            {
                fontSize = 14,
                fontStyle = FontStyle.Bold,
                normal = { background = cardTexture, textColor = new Color(0.88f, 0.94f, 1f, 1f) },
                hover = { background = activeTabTexture, textColor = Color.white },
                active = { background = activeTabTexture, textColor = Color.white }
            };

            activeTabStyle = new GUIStyle(tabStyle)
            {
                normal = { background = activeTabTexture, textColor = Color.white }
            };

            inputStyle = new GUIStyle(GUI.skin.textField)
            {
                fontSize = 17,
                alignment = TextAnchor.MiddleRight
            };

            codeInputStyle = new GUIStyle(GUI.skin.textArea)
            {
                fontSize = 19,
                wordWrap = true,
                normal = { background = codeTexture, textColor = new Color(0.90f, 0.98f, 1f, 1f) },
                focused = { background = codeTexture, textColor = Color.white },
                hover = { background = codeTexture, textColor = Color.white },
                active = { background = codeTexture, textColor = Color.white },
                padding = new RectOffset(10, 10, 8, 8)
            };

            badgeStyle = new GUIStyle(cardStyle)
            {
                alignment = TextAnchor.MiddleCenter
            };
        }

        private static Texture2D MakeTexture(Color color)
        {
            Texture2D texture = new Texture2D(1, 1);
            texture.SetPixel(0, 0, color);
            texture.Apply();
            return texture;
        }
    }
}
