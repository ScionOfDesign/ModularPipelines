using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("resource-manager", "folders", "set-iam-policy")]
public record GcloudResourceManagerFoldersSetIamPolicyOptions(
[property: PositionalArgument] string FolderId,
[property: PositionalArgument] string PolicyFile
) : GcloudOptions;