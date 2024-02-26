using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Terraform.Options;

[CommandPrecedingArguments("destroy")]
[ExcludeFromCodeCoverage]
public record TerraformDestroyOptions : TerraformApprovalOptions;