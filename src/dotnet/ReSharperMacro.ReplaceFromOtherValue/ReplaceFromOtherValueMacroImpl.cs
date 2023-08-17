using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;

namespace ReSharperMacro.ReplaceFromOtherValue;

[MacroImplementation(Definition = typeof(ReplaceFromOtherValueMacroDef))]
public class ReplaceFromOtherValueMacroImpl : SimpleMacroImplementation
{
    private readonly IMacroParameterValueNew _variableArgument;
    private readonly IMacroParameterValueNew _regexArgument;
    private readonly IMacroParameterValueNew _replacementArgument;
    private readonly Type[] _ignoredException = { typeof(ArgumentException) };

    public ReplaceFromOtherValueMacroImpl([Optional] MacroParameterValueCollection arguments)
    {
        _variableArgument = arguments.OptionalFirstOrDefault();
        _regexArgument = arguments == null || arguments.Count < 2 ? null : arguments[1];
        _replacementArgument = arguments == null || arguments.Count < 3 ? null : arguments[2];
    }

    public override string EvaluateQuickResult(IHotspotContext context)
    {
        if (_variableArgument == null)
            return null;
        string value = _variableArgument.GetValue();
        string regex = _regexArgument?.GetValue() ?? string.Empty;
        string replace = _replacementArgument?.GetValue() ?? string.Empty;
        if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(regex)) return value;
        try
        {
            return Regex.Replace(value, regex, replace);
        }
        catch (Exception exception) when(_ignoredException.Any(x => x.IsInstanceOfType(exception)))
        {
            return value;
        }
    }
}