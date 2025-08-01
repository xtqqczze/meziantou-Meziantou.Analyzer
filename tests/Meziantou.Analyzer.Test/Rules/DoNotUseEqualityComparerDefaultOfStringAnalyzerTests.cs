﻿using Meziantou.Analyzer.Rules;
using TestHelper;
using Xunit;

namespace Meziantou.Analyzer.Test.Rules;

public sealed class DoNotUseEqualityComparerDefaultOfStringAnalyzerTests
{
    private static ProjectBuilder CreateProjectBuilder()
    {
        return new ProjectBuilder()
            .WithAnalyzer<DoNotUseEqualityComparerDefaultOfStringAnalyzer>()
            .WithCodeFixProvider<DoNotUseEqualityComparerDefaultOfStringFixer>();
    }

    [Fact]
    public async Task TestAsync()
    {
        const string SourceCode = @"using System.Collections.Generic;
class Test
{
    internal void Sample()
    {
        _ = EqualityComparer<int>.Default.Equals(0, 0);
        _ = [||]EqualityComparer<string>.Default.Equals(null, null);
    }
}
";
        const string CodeFix = @"using System.Collections.Generic;
class Test
{
    internal void Sample()
    {
        _ = EqualityComparer<int>.Default.Equals(0, 0);
        _ = System.StringComparer.Ordinal.Equals(null, null);
    }
}
";
        await CreateProjectBuilder()
              .WithSourceCode(SourceCode)
              .ShouldFixCodeWith(CodeFix)
              .ValidateAsync();
    }
}
