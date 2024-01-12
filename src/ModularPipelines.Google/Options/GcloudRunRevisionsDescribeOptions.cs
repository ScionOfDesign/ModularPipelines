using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("run", "revisions", "describe")]
public record GcloudRunRevisionsDescribeOptions(
[property: PositionalArgument] string Revision,
[property: PositionalArgument] string Namespace
) : GcloudOptions
{
    [CommandSwitch("--platform")]
    public string? Platform { get; set; }

    [CommandSwitch("--region")]
    public string? Region { get; set; }

    [CommandSwitch("--cluster")]
    public string? Cluster { get; set; }

    [CommandSwitch("--cluster-location")]
    public string? ClusterLocation { get; set; }

    [CommandSwitch("--context")]
    public string? Context { get; set; }

    [CommandSwitch("--kubeconfig")]
    public string? Kubeconfig { get; set; }
}