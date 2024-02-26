using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Terraform.Options;

[CommandPrecedingArguments("show")]
[ExcludeFromCodeCoverage]
public record TerraformShowOptions : TerraformPrintedOptions
{
    [BooleanCommandSwitch("-refresh")]
    public bool? Refresh { get; set; }
}