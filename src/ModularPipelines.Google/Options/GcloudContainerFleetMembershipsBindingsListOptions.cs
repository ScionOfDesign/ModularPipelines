using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("container", "fleet", "memberships", "bindings", "list")]
public record GcloudContainerFleetMembershipsBindingsListOptions(
[property: CommandSwitch("--membership")] string Membership
) : GcloudOptions
{
    [CommandSwitch("--location")]
    public string? Location { get; set; }
}