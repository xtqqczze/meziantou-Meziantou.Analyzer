﻿using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace Meziantou.Analyzer.Suppressors;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class IDE0058Suppressor : DiagnosticSuppressor
{
    private static readonly SuppressionDescriptor Descriptor = new(
        id: "MAS0003",
        suppressedDiagnosticId: "IDE0058",
        justification: "Suppress IDE0058 on well-known types"
    );

    public override ImmutableArray<SuppressionDescriptor> SupportedSuppressions => ImmutableArray.Create(Descriptor);

    public override void ReportSuppressions(SuppressionAnalysisContext context)
    {
#pragma warning disable IDE1006 // Naming Styles
        var System_Text_StringBuilder = context.Compilation.GetBestTypeByMetadataName("System.Text.StringBuilder");
        var System_IO_Directory = context.Compilation.GetBestTypeByMetadataName("System.IO.Directory");
#pragma warning restore IDE1006

        foreach (var diagnostic in context.ReportedDiagnostics)
        {
            var tree = diagnostic.Location.SourceTree;
            if (tree is null)
                continue;

            var semanticModel = context.GetSemanticModel(tree);
            if (semanticModel is null)
                continue;

            var node = tree.GetRoot(context.CancellationToken).FindNode(diagnostic.Location.SourceSpan);
            var operation = semanticModel.GetOperation(node, context.CancellationToken);
            if (operation is IInvocationOperation invocation)
            {
                // StringBuilder
                if (invocation.TargetMethod.Name is "Append" or "AppendLine" or "AppendJoin" or "AppendFormat" or "Clear" or "Remove" or "Insert" or "Replace" && invocation.TargetMethod.ContainingType.IsEqualTo(System_Text_StringBuilder))
                {
                    context.ReportSuppression(Suppression.Create(Descriptor, diagnostic));
                }

                // Directory.CreateDirectory
                if (invocation.TargetMethod.Name is "CreateDirectory" && invocation.TargetMethod.ContainingType.IsEqualTo(System_IO_Directory))
                {
                    context.ReportSuppression(Suppression.Create(Descriptor, diagnostic));
                }
            }
        }
    }
}
