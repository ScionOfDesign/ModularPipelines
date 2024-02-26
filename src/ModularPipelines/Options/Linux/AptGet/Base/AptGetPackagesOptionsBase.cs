using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Options.Linux.AptGet.Base;

[ExcludeFromCodeCoverage]
public abstract record AptGetPackagesOptionsBase : AptGetOptionsBase
{
    protected AptGetPackagesOptionsBase(params string[] packages) : base()
    {
        Packages = packages;
    }

    public string? Package
    {
        get => Packages?[0];
        init => Packages = [value ?? throw new ArgumentNullException(nameof(Package), $"{nameof(Package)} cannot be null!")];
    }

    [PositionalArgument(Position = Position.AfterSwitches)]
    public string[]? Packages { get; init; }
}
