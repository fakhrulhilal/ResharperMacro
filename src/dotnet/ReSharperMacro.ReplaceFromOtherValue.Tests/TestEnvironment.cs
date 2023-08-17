using System.Threading;
using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.Feature.Services;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.TestFramework;
using JetBrains.TestFramework;
using JetBrains.TestFramework.Application.Zones;
using NUnit.Framework;

[assembly: Apartment(ApartmentState.STA)]
namespace ReSharperMacro.ReplaceFromOtherValue.Tests
{
    [ZoneDefinition]
    public class ReplaceFromOtherValueTestEnvironmentZone : ITestsEnvZone, IRequire<PsiFeatureTestZone>, IRequire<IReplaceFromOtherValueZone> { }

    [ZoneMarker]
    public class ZoneMarker : IRequire<ICodeEditingZone>, IRequire<ILanguageCSharpZone>, IRequire<ReplaceFromOtherValueTestEnvironmentZone> { }

    [SetUpFixture]
    public class ReplaceFromOtherValueTestsAssembly : ExtensionTestEnvironmentAssembly<ReplaceFromOtherValueTestEnvironmentZone> { }
}
