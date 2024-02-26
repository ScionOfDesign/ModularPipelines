using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Terraform.Options;

[CommandPrecedingArguments("apply")]
[ExcludeFromCodeCoverage]
public record TerraformApplyOptions : TerraformApprovalOptions
{
    [BooleanCommandSwitch("-state-out")]
    public bool? StateOut { get; set; }

    [BooleanCommandSwitch("-backup")]
    public bool? Backup { get; set; }
}