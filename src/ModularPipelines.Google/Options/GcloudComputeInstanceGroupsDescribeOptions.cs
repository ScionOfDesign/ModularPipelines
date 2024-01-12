using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("compute", "instance-groups", "describe")]
public record GcloudComputeInstanceGroupsDescribeOptions(
[property: PositionalArgument] string Name
) : GcloudOptions
{
    [CommandSwitch("--region")]
    public string? Region { get; set; }

    [CommandSwitch("--zone")]
    public string? Zone { get; set; }
}