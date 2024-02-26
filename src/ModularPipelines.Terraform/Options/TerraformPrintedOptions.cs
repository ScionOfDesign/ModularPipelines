using ModularPipelines.Attributes;

namespace ModularPipelines.Terraform.Options;

public abstract record TerraformPrintedOptions : TerraformOptions
{
    [BooleanCommandSwitch("-json")]
    public bool? Json { get; set; }

    [BooleanCommandSwitch("-raw")]
    public bool? Raw { get; set; }

    [BooleanCommandSwitch("-no-color")]
    public bool? NoColor { get; set; }

    [CommandSwitch("-state")]
    public string? State { get; set; }
}
