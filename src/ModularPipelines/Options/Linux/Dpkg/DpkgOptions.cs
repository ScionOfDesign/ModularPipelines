using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Options.Linux.Dpkg;

[ExcludeFromCodeCoverage]
public record DpkgOptions : CommandLineToolOptions
{
    public DpkgOptions() : base("dpkg")
    {
    }

    [CommandSwitch("--install")]
    public string? InstallPackage { get; set; }

    [CommandSwitch("--status")]
    public string? PackageStatus { get; set; }
}
