using ModularPipelines.Attributes;

namespace ModularPipelines.Options.Linux.Which;

public sealed record WhichOptions : CommandLineToolOptions
{
    public WhichOptions(params string[] filenames) : base("which")
    {
        Filenames = filenames;
    }

    [BooleanCommandSwitch("-a")]
    public bool? All { get; set; }

    [PositionalArgument(Position = Position.AfterSwitches)]
    public IEnumerable<string> Filenames { get; set; }
}
