using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Options.Linux.AptGet.Base;

namespace ModularPipelines.Options.Linux.AptGet;

[ExcludeFromCodeCoverage]
public record AptGetInstallOptions : AptGetPackagesOptionsBase
{
    public AptGetInstallOptions() : base()
    {
    }

    public AptGetInstallOptions(params string[] packages) : base(packages)
    {
    }

    [PositionalArgument(Position = Position.AfterSwitches)]
    public string CommandName { get; } = "install";
}