using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Terraform.Options;

[CommandPrecedingArguments("refresh")]
[ExcludeFromCodeCoverage]
public record TerraformRefreshOptions : TerraformApprovalOptions
{
    [BooleanCommandSwitch("-refresh-only")]
    public bool? RefreshOnly { get; set; }
}