using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("container", "operations", "list")]
public record GcloudContainerOperationsListOptions : GcloudOptions
{
    [CommandSwitch("--location")]
    public string? Location { get; set; }

    [CommandSwitch("--region")]
    public string? Region { get; set; }

    [CommandSwitch("--zone")]
    public string? Zone { get; set; }
}