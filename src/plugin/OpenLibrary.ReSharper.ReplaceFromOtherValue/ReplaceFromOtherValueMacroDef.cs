using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;

namespace OpenLibrary.ReSharper.ReplaceFromOtherValue
{
    [MacroDefinition("replaceFromOtherValue", ShortDescription = Definition.QuickDescription, LongDescription = Definition.CompleteDescription)]
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
