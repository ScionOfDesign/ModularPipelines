using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Options.Linux.AptGet.Base;

namespace ModularPipelines.Options.Linux.AptGet;

[ExcludeFromCodeCoverage]
public record AptGetUpdateOptions : AptGetOptionsBase
{
    [PositionalArgument(Position = Position.AfterSwitches)]
    public string CommandName { get; } = "update";
}