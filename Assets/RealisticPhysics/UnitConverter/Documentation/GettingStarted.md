# \# Getting Started

# 

# UnitConverter gives Unity developers a simple way to convert between supported units at runtime, through direct converter methods, extension methods, and inspector-friendly settings.

# 

# Use this guide to import the package, open the settings asset, and run your first conversions.

# 

# \## Import the Package

# 

# Import the package into your Unity project using the Unity Package Manager, the Asset Store import flow, or by copying the package files into your project.

# 

# After import, UnitConverter will be available under:

# 

# ```text

# Assets/RealisticPhysics/Core

# Assets/RealisticPhysics/UnitConverter

# ```

# 

# The package is ready to use after Unity finishes importing and compiling the scripts.

# 

# \## Open the Settings

# 

# Open the UnitConverter settings from the Unity menu:

# 

# ```text

# Tools > RealisticPhysics > UnitConverter > Open Settings

# ```

# 

# If the settings asset does not exist yet, UnitConverter will create it automatically at:

# 

# ```text

# Assets/RealisticPhysics/UnitConverter/Settings/UnitConverterSettings.asset

# ```

# 

# You can use the settings asset to manage project-level UnitConverter options and inspector override behavior.

# 

# \## Choose a Conversion Style

# 

# UnitConverter supports three common runtime workflows:

# 

# 1\. \*\*Router API\*\* — best for flexible conversions inside a unit family.

# 2\. \*\*Extension methods\*\* — best for readable value-based conversions.

# 3\. \*\*Direct methods\*\* — best when you want clear method names and auto-complete support.

# 

# Most developers should start with the router API, then use extension methods or direct methods where they make the code easier to read.

# 

# \## First Runtime Conversion

# 

# Use the router API when the source and target units are selected at runtime, stored in variables, or chosen from a UI.

# 

# ```csharp

# using RealisticPhysics.UnitConversion.Length;

# 

# public class Example

# {

# &#x20;   public double ConvertExample()

# &#x20;   {

# &#x20;       return UnitConverterLength.Convert(

# &#x20;           1.5,

# &#x20;           UnitConverterLengthUnit.Meter,

# &#x20;           UnitConverterLengthUnit.Centimeter);

# &#x20;   }

# }

# ```

# 

# This converts `1.5` meters into centimeters.

# 

# \## First Extension Conversion

# 

# Use extension methods when you want the value itself to read naturally as part of the conversion.

# 

# ```csharp

# using RealisticPhysics.UnitConversion.Length;

# 

# public class Example

# {

# &#x20;   public double ConvertExample()

# &#x20;   {

# &#x20;       double value = 1.5;

# 

# &#x20;       return value.Convert(

# &#x20;           UnitConverterLengthUnit.Meter,

# &#x20;           UnitConverterLengthUnit.Centimeter);

# &#x20;   }

# }

# ```

# 

# This is useful for gameplay code, tools, calculators, simulation values, and other places where readability matters.

# 

# \## First Direct Method Conversion

# 

# Use direct methods when you already know the exact units you want to convert between.

# 

# ```csharp

# using RealisticPhysics.UnitConversion.Length.Metric;

# 

# public class Example

# {

# &#x20;   public double ConvertExample()

# &#x20;   {

# &#x20;       return UnitConverterMetricLength.MeterToCentimeter(1.5);

# &#x20;   }

# }

# ```

# 

# Direct methods are convenient when you want fast auto-complete and clear method names for a specific unit system, such as Metric Length or Imperial Volume.

# 

# \## Recommended Developer Workflow

# 

# Start with the router API while building your feature. It is flexible and works across all supported units within the same conversion family.

# 

# Use direct methods for fixed conversions that should be obvious at a glance.

# 

# Use extension methods when they make the calling code shorter and easier to read.

# 

# For inspector-driven workflows, open the UnitConverter settings and configure the available override behavior for your project.

# 

# \## Next Steps

# 

# After your first conversion works, explore the supported conversion families and units included with the package. You can also use the runtime demo to browse available families, inspect base-unit conversions, and review example usage patterns.



