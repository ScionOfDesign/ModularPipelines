using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("edge-cloud", "container", "vpn-connections", "list")]
public record GcloudEdgeCloudContainerVpnConnectionsListOptions : GcloudOptions
{
    [CommandSwitch("--location")]
    public string? Location { get; set; }
}