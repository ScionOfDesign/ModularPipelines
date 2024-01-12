using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("compute", "tpus", "tpu-vm", "stop")]
public record GcloudComputeTpusTpuVmStopOptions(
[property: PositionalArgument] string Tpu,
[property: PositionalArgument] string Zone
) : GcloudOptions
{
    [BooleanCommandSwitch("--async")]
    public bool? Async { get; set; }
}