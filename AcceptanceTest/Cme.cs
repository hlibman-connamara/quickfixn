using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;
using QuickFix;

namespace AcceptanceTest;

public class Cme : TestBase
{
    private const string DefinitionsBaseDirPath = "definitions/server/cme";

    protected override SessionSettings Settings => new("cfg/at_cme.cfg");

    [TestCaseSource(nameof(Definitions))]
    public void CmeTest(string definitionFileName)
    {
        RunTest(Path.Combine(DefinitionsBaseDirPath, definitionFileName));
    }

    private static IEnumerable<string> Definitions()
    {
        return Directory.EnumerateFiles(DefinitionsBaseDirPath, "*.def")
            .Select(f => Path.GetFileName((string?)f)!)
            .OrderBy(s => s);
    }
}