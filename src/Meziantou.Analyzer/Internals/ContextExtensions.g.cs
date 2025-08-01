
#nullable enable
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace Meziantou.Analyzer.Internals;

internal static partial class ContextExtensions
{

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, IEnumerable<Location> locations, string?[]? messageArgs = null) => ReportDiagnostic(new DiagnosticReporter(context), descriptor, locations, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IEnumerable<Location> locations, params string?[]? messageArgs) => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, locations, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxToken syntaxToken, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, syntaxToken, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, SyntaxToken syntaxToken, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, syntaxToken, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxNode syntaxNode, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, syntaxNode, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, SyntaxNode syntaxNode, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, syntaxNode, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, ISymbol symbol, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, ImmutableDictionary<string, string?>.Empty, symbol, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, ISymbol symbol, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, IFieldSymbol symbol, DiagnosticFieldReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, symbol, reportOptions, messageArgs);
        
    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IFieldSymbol symbol, DiagnosticFieldReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, IMethodSymbol symbol, DiagnosticMethodReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IMethodSymbol symbol, DiagnosticMethodReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, reportOptions, messageArgs);
        
    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, IParameterSymbol symbol, DiagnosticParameterReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IParameterSymbol symbol, DiagnosticParameterReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, reportOptions, messageArgs);
        
    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, IPropertySymbol symbol, DiagnosticPropertyReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IPropertySymbol symbol, DiagnosticPropertyReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, Location location, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, location, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, Location location, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, location, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxReference syntaxReference, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, syntaxReference, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, SyntaxReference syntaxReference, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, syntaxReference, messageArgs);
        
    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, IInvocationOperation operation, DiagnosticInvocationReportOptions options, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties: null, operation, options, messageArgs);
        
    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IInvocationOperation operation, DiagnosticInvocationReportOptions options, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, operation, options, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, ILocalFunctionOperation operation, DiagnosticMethodReportOptions options, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, operation, options, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, IOperation operation, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, operation, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IOperation operation, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, operation, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, AttributeData attribute, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, attribute, messageArgs);

    public static void ReportDiagnostic(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, AttributeData attribute, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, attribute, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, IEnumerable<Location> locations, string?[]? messageArgs = null) => ReportDiagnostic(new DiagnosticReporter(context), descriptor, locations, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IEnumerable<Location> locations, params string?[]? messageArgs) => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, locations, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxToken syntaxToken, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, syntaxToken, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, SyntaxToken syntaxToken, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, syntaxToken, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxNode syntaxNode, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, syntaxNode, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, SyntaxNode syntaxNode, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, syntaxNode, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, ISymbol symbol, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, ImmutableDictionary<string, string?>.Empty, symbol, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, ISymbol symbol, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, IFieldSymbol symbol, DiagnosticFieldReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, symbol, reportOptions, messageArgs);
        
    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IFieldSymbol symbol, DiagnosticFieldReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, IMethodSymbol symbol, DiagnosticMethodReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IMethodSymbol symbol, DiagnosticMethodReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, reportOptions, messageArgs);
        
    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, IParameterSymbol symbol, DiagnosticParameterReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IParameterSymbol symbol, DiagnosticParameterReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, reportOptions, messageArgs);
        
    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, IPropertySymbol symbol, DiagnosticPropertyReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IPropertySymbol symbol, DiagnosticPropertyReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, Location location, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, location, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, Location location, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, location, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxReference syntaxReference, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, syntaxReference, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, SyntaxReference syntaxReference, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, syntaxReference, messageArgs);
        
    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, IInvocationOperation operation, DiagnosticInvocationReportOptions options, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties: null, operation, options, messageArgs);
        
    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IInvocationOperation operation, DiagnosticInvocationReportOptions options, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, operation, options, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, ILocalFunctionOperation operation, DiagnosticMethodReportOptions options, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, operation, options, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, IOperation operation, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, operation, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IOperation operation, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, operation, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, AttributeData attribute, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, attribute, messageArgs);

    public static void ReportDiagnostic(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, AttributeData attribute, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, attribute, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, IEnumerable<Location> locations, string?[]? messageArgs = null) => ReportDiagnostic(new DiagnosticReporter(context), descriptor, locations, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IEnumerable<Location> locations, params string?[]? messageArgs) => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, locations, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxToken syntaxToken, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, syntaxToken, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, SyntaxToken syntaxToken, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, syntaxToken, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxNode syntaxNode, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, syntaxNode, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, SyntaxNode syntaxNode, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, syntaxNode, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, ISymbol symbol, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, ImmutableDictionary<string, string?>.Empty, symbol, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, ISymbol symbol, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, IFieldSymbol symbol, DiagnosticFieldReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, symbol, reportOptions, messageArgs);
        
    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IFieldSymbol symbol, DiagnosticFieldReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, IMethodSymbol symbol, DiagnosticMethodReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IMethodSymbol symbol, DiagnosticMethodReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, reportOptions, messageArgs);
        
    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, IParameterSymbol symbol, DiagnosticParameterReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IParameterSymbol symbol, DiagnosticParameterReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, reportOptions, messageArgs);
        
    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, IPropertySymbol symbol, DiagnosticPropertyReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IPropertySymbol symbol, DiagnosticPropertyReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, Location location, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, location, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, Location location, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, location, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxReference syntaxReference, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, syntaxReference, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, SyntaxReference syntaxReference, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, syntaxReference, messageArgs);
        
    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, IInvocationOperation operation, DiagnosticInvocationReportOptions options, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties: null, operation, options, messageArgs);
        
    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IInvocationOperation operation, DiagnosticInvocationReportOptions options, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, operation, options, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, ILocalFunctionOperation operation, DiagnosticMethodReportOptions options, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, operation, options, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, IOperation operation, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, operation, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IOperation operation, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, operation, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, AttributeData attribute, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, attribute, messageArgs);

    public static void ReportDiagnostic(this OperationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, AttributeData attribute, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, attribute, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, IEnumerable<Location> locations, string?[]? messageArgs = null) => ReportDiagnostic(new DiagnosticReporter(context), descriptor, locations, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IEnumerable<Location> locations, params string?[]? messageArgs) => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, locations, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxToken syntaxToken, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, syntaxToken, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, SyntaxToken syntaxToken, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, syntaxToken, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxNode syntaxNode, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, syntaxNode, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, SyntaxNode syntaxNode, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, syntaxNode, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, ISymbol symbol, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, ImmutableDictionary<string, string?>.Empty, symbol, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, ISymbol symbol, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, IFieldSymbol symbol, DiagnosticFieldReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, symbol, reportOptions, messageArgs);
        
    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IFieldSymbol symbol, DiagnosticFieldReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, IMethodSymbol symbol, DiagnosticMethodReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IMethodSymbol symbol, DiagnosticMethodReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, reportOptions, messageArgs);
        
    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, IParameterSymbol symbol, DiagnosticParameterReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IParameterSymbol symbol, DiagnosticParameterReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, reportOptions, messageArgs);
        
    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, IPropertySymbol symbol, DiagnosticPropertyReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IPropertySymbol symbol, DiagnosticPropertyReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, Location location, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, location, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, Location location, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, location, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxReference syntaxReference, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, syntaxReference, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, SyntaxReference syntaxReference, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, syntaxReference, messageArgs);
        
    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, IInvocationOperation operation, DiagnosticInvocationReportOptions options, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties: null, operation, options, messageArgs);
        
    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IInvocationOperation operation, DiagnosticInvocationReportOptions options, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, operation, options, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, ILocalFunctionOperation operation, DiagnosticMethodReportOptions options, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, operation, options, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, IOperation operation, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, operation, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IOperation operation, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, operation, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, AttributeData attribute, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, attribute, messageArgs);

    public static void ReportDiagnostic(this OperationBlockAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, AttributeData attribute, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, attribute, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, IEnumerable<Location> locations, string?[]? messageArgs = null) => ReportDiagnostic(new DiagnosticReporter(context), descriptor, locations, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IEnumerable<Location> locations, params string?[]? messageArgs) => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, locations, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxToken syntaxToken, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, syntaxToken, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, SyntaxToken syntaxToken, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, syntaxToken, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxNode syntaxNode, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, syntaxNode, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, SyntaxNode syntaxNode, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, syntaxNode, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, ISymbol symbol, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, ImmutableDictionary<string, string?>.Empty, symbol, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, ISymbol symbol, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, IFieldSymbol symbol, DiagnosticFieldReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, symbol, reportOptions, messageArgs);
        
    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IFieldSymbol symbol, DiagnosticFieldReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, IMethodSymbol symbol, DiagnosticMethodReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IMethodSymbol symbol, DiagnosticMethodReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, reportOptions, messageArgs);
        
    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, IParameterSymbol symbol, DiagnosticParameterReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IParameterSymbol symbol, DiagnosticParameterReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, reportOptions, messageArgs);
        
    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, IPropertySymbol symbol, DiagnosticPropertyReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IPropertySymbol symbol, DiagnosticPropertyReportOptions reportOptions, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, symbol, reportOptions, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, Location location, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, location, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, Location location, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, location, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxReference syntaxReference, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, syntaxReference, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, SyntaxReference syntaxReference, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, syntaxReference, messageArgs);
        
    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, IInvocationOperation operation, DiagnosticInvocationReportOptions options, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties: null, operation, options, messageArgs);
        
    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IInvocationOperation operation, DiagnosticInvocationReportOptions options, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, operation, options, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, ILocalFunctionOperation operation, DiagnosticMethodReportOptions options, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, operation, options, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, IOperation operation, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, operation, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, IOperation operation, params string?[] messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, operation, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, AttributeData attribute, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, attribute, messageArgs);

    public static void ReportDiagnostic(this CompilationAnalysisContext context, DiagnosticDescriptor descriptor, ImmutableDictionary<string, string?>? properties, AttributeData attribute, params string?[]? messageArgs)
        => ReportDiagnostic(new DiagnosticReporter(context), descriptor, properties, attribute, messageArgs);
}
