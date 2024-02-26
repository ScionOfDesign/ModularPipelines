using ModularPipelines.Attributes;

namespace ModularPipelines.Terraform.Options;

public abstract record TerraformApprovalOptions : TerraformPrintedOptions
{
    [BooleanCommandSwitch("-auto-approve")]
    public bool? AutoApprove { get; set; }
}