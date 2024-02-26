using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Options.Linux.AptGet.Base;

namespace ModularPipelines.Options.Linux.AptGet;

[ExcludeFromCodeCoverage]
public record AptGetRemoveOptions : AptGetPackagesOptionsBase
{
    public AptGetRemoveOptions() : base()
    {
    }

    public AptGetRemoveOptions(params string[] packages) : base(packages)
    {
    }

    [PositionalArgument(Position = Position.AfterSwitches)]
    public string CommandName { get; } = "remove";
}