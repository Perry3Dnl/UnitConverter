namespace UnitConverter.Analyzers
{
    using System.Collections.Immutable;
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
            "Dynamic conversion uses compile-time-known unit text; prefer a typed or family-specific UnitConverter API when the family is known",
            "Usage",
            DiagnosticSeverity.Warning,
            isEnabledByDefault: true,
            description:
                "UnitConverterDynamic is an intentional escape hatch. When both unit expressions are compile-time constants, a family-specific or strongly typed API can preserve more compile-time safety.");

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
                method.Name != "Convert" ||
                method.ContainingType == null ||
                method.ContainingType.ToDisplayString() != "UnitConverter.UnitConverterDynamic")
            {
                return;
            }

            SeparatedSyntaxList<ArgumentSyntax> arguments = invocation.ArgumentList.Arguments;
            if (arguments.Count < 2)
            {
                return;
            }

            Optional<object> firstConstant =
                context.SemanticModel.GetConstantValue(arguments[0].Expression);
            Optional<object> secondConstant =
                context.SemanticModel.GetConstantValue(arguments[1].Expression);

            if (!firstConstant.HasValue ||
                !(firstConstant.Value is string) ||
                !secondConstant.HasValue ||
                !(secondConstant.Value is string))
            {
                return;
            }

            context.ReportDiagnostic(
                Diagnostic.Create(
                    Rule,
                    invocation.GetLocation()));
        }
    }
}
