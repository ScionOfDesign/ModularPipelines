using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("compute", "routers", "nats", "rules", "describe")]
public record GcloudComputeRoutersNatsRulesDescribeOptions(
[property: PositionalArgument] string RuleNumber,
[property: CommandSwitch("--nat")] string Nat,
[property: CommandSwitch("--router")] string Router
) : GcloudOptions
{
    [CommandSwitch("--region")]
    public string? Region { get; set; }
}