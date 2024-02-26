using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Options;

namespace ModularPipelines.Terraform.Options;

[ExcludeFromCodeCoverage]
public abstract record TerraformOptions() : CommandLineToolOptions("terraform")
{
    [PositionalArgument(Position = Position.BeforeSwitches)]
    [BooleanCommandSwitch("-chdir")]
    public bool? Chdir { get; set; }
}