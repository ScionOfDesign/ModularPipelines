using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Models;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("network-connectivity", "spokes", "linked-interconnect-attachments", "create")]
public record GcloudNetworkConnectivitySpokesLinkedInterconnectAttachmentsCreateOptions(
[property: PositionalArgument] string Spoke,
[property: PositionalArgument] string Region,
[property: CommandSwitch("--hub")] string Hub,
[property: CommandSwitch("--interconnect-attachments")] string[] InterconnectAttachments
) : GcloudOptions
{
    [BooleanCommandSwitch("--async")]
    public bool? Async { get; set; }

    [CommandSwitch("--description")]
    public string? Description { get; set; }

    [CommandSwitch("--labels")]
    public IEnumerable<KeyValue>? Labels { get; set; }

    [BooleanCommandSwitch("--site-to-site-data-transfer")]
    public bool? SiteToSiteDataTransfer { get; set; }
}