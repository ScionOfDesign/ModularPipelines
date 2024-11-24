using ModularPipelines.Attributes;

namespace ModularPipelines.Options.Linux.Sum;

public abstract record SumOptions : CommandLineToolOptions
{
    protected SumOptions(string tool, params string[] filenames) : base(tool)
    {
        Filenames = filenames;
    }

    [BooleanCommandSwitch("-b")]
    public bool? Binary { get; set; }

    [BooleanCommandSwitch("-c")]
    public bool? Check { get; set; }

    [BooleanCommandSwitch("-t")]
    public bool? Text { get; set; }

    [BooleanCommandSwitch("-z")]
    public bool? Zero { get; set; }

    [BooleanCommandSwitch("--tag")]
    public bool? Tag { get; set; }

    [BooleanCommandSwitch("--ignore-missing")]
    public bool? IgnoreMissing { get; set; }

    [BooleanCommandSwitch("--quiet")]
    public bool? Quiet { get; set; }

    [BooleanCommandSwitch("--status")]
    public bool? Status { get; set; }

    [BooleanCommandSwitch("--strict")]
    public bool? Strict { get; set; }

    [BooleanCommandSwitch("--warn")]
    public bool? Warn { get; set; }

    [PositionalArgument(Position = Position.AfterSwitches)]
    public IEnumerable<string> Filenames { get; set; }
}
