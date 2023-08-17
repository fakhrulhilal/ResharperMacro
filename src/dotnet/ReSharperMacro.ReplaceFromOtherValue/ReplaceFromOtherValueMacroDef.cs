using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;

namespace ReSharperMacro.ReplaceFromOtherValue;

[MacroDefinition("replaceFromOtherValue", DescriptionResourceName = Definition.QuickDescription, LongDescriptionResourceName = Definition.CompleteDescription)]
public class ReplaceFromOtherValueMacroDef : SimpleMacroDefinition
{
    public override ParameterInfo[] Parameters => new[]
    {
        new ParameterInfo(ParameterType.VariableReference),
        new ParameterInfo(ParameterType.String), 
        new ParameterInfo(ParameterType.String),
    };
}