namespace ModularPipelines.Options.Linux.Sum;

public sealed record Sha256SumOptions : SumOptions
{
    public Sha256SumOptions(params string[] filenames) : base("sha256sum", filenames)
    {
    }
}
