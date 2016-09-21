using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;

namespace Fakhrulhilal.Macro.ReplaceFromOtherValue
{
    [MacroDefinition("replaceFromOtherValue", ShortDescription = "Value of {#0: another variable} with replacing certain value", LongDescription = "Evaluate value from another variable with replacing some parts using regex")]
    public class ReplaceFromOtherValueMacroDef : SimpleMacroDefinition
    {
        public override ParameterInfo[] Parameters => new[]
        {
            new ParameterInfo(ParameterType.VariableReference),
            new ParameterInfo(ParameterType.String), 
            new ParameterInfo(ParameterType.String) 
        };
    }
}
