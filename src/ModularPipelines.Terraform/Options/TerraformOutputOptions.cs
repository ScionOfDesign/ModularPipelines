using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Terraform.Options;

[CommandPrecedingArguments("output")]
[ExcludeFromCodeCoverage]
public record TerraformOutputOptions : TerraformPrintedOptions
{
    [PositionalArgument(Position = Position.AfterSwitches)]
    public string? Name { get; set; }
}