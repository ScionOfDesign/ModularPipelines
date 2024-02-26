using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Options.Linux.AptGet;

[ExcludeFromCodeCoverage]
public record AptGetUpgradeOptions : AptGetOptionsBase
{
    [PositionalArgument(Position = Position.AfterSwitches)]
    public string CommandName { get; } = "upgrade";
}