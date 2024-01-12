using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("services", "vpc-peerings", "get-vpc-service-controls")]
public record GcloudServicesVpcPeeringsGetVpcServiceControlsOptions(
[property: CommandSwitch("--network")] string Network
) : GcloudOptions
{
    [CommandSwitch("--service")]
    public string? Service { get; set; }
}