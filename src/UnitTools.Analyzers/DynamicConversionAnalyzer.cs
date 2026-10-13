namespace UnitTools.Analyzers
{
    using System;
    using System.Collections.Immutable;
    using System.Globalization;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using Microsoft.CodeAnalysis.Diagnostics;

    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public sealed class DynamicConversionAnalyzer : DiagnosticAnalyzer
    {
        public const string DiagnosticId = "UC0002";

        private static readonly DiagnosticDescriptor Rule = new DiagnosticDescriptor(
            DiagnosticId,
            "Prefer a typed or family-specific conversion when units are known",
            "Dynamic conversion uses compile-time-known unit text; prefer a typed or family-specific UnitTools API when the family is known",
            "Usage",
            DiagnosticSeverity.Warning,
            isEnabledByDefault: true,
            description:
                "UnitToolsDynamic is an intentional escape hatch. When both unit expressions are compile-time constants, a family-specific or strongly typed API can preserve more compile-time safety.");

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics =>
            ImmutableArray.Create(Rule);

        public override void Initialize(AnalysisContext context)
        {
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
            context.EnableConcurrentExecution();
            context.RegisterSyntaxNodeAction(
                AnalyzeInvocation,
                Microsoft.CodeAnalysis.CSharp.SyntaxKind.InvocationExpression);
        }

        private static void AnalyzeInvocation(SyntaxNodeAnalysisContext context)
        {
            InvocationExpressionSyntax invocation =
                (InvocationExpressionSyntax)context.Node;

            IMethodSymbol method =
                context.SemanticModel.GetSymbolInfo(invocation).Symbol as IMethodSymbol;

            if (method == null ||
                (method.Name != "Convert" && method.Name != "TryConvert") ||
                method.ContainingType == null ||
                method.ContainingType.ToDisplayString() != "UnitTools.UnitToolsDynamic")
            {
                return;
            }

            SeparatedSyntaxList<ArgumentSyntax> arguments = invocation.ArgumentList.Arguments;
            int inputIndex = FindParameterIndex(method, "input");
            int targetIndex = FindParameterIndex(method, "toUnit");

            if (inputIndex < 0 ||
                targetIndex < 0 ||
                inputIndex >= arguments.Count ||
                targetIndex >= arguments.Count)
            {
                return;
            }

            Optional<object> inputConstant =
                context.SemanticModel.GetConstantValue(arguments[inputIndex].Expression);
            Optional<object> targetConstant =
                context.SemanticModel.GetConstantValue(arguments[targetIndex].Expression);

            if (!inputConstant.HasValue ||
                !(inputConstant.Value is string) ||
                !targetConstant.HasValue ||
                !(targetConstant.Value is string))
            {
                return;
            }

            string input = (string)inputConstant.Value;
            string target = (string)targetConstant.Value;

            if (!LooksLikeInvariantQuantity(input) ||
                string.IsNullOrWhiteSpace(target))
            {
                return;
            }

            context.ReportDiagnostic(
                Diagnostic.Create(
                    Rule,
                    invocation.GetLocation()));
        }

        private static int FindParameterIndex(
            IMethodSymbol method,
            string parameterName)
        {
            for (int index = 0; index < method.Parameters.Length; index++)
            {
                if (string.Equals(
                    method.Parameters[index].Name,
                    parameterName,
                    StringComparison.Ordinal))
                {
                    return index;
                }
            }

            return -1;
        }

        private static bool LooksLikeInvariantQuantity(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            string text = input.Trim();
            for (int splitIndex = text.Length - 1; splitIndex > 0; splitIndex--)
            {
                string numberPart = text.Substring(0, splitIndex).TrimEnd();
                string unitPart = text.Substring(splitIndex).Trim();

                if (unitPart.Length == 0)
                {
                    continue;
                }

                double ignored;
                if (double.TryParse(
                    numberPart,
                    NumberStyles.Float | NumberStyles.AllowThousands,
                    CultureInfo.InvariantCulture,
                    out ignored))
                {
                    return true;
                }
            }

            return false;
        }
    }
}