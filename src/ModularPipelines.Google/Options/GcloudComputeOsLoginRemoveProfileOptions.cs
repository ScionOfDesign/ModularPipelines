using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("compute", "os-login", "remove-profile")]
public record GcloudComputeOsLoginRemoveProfileOptions : GcloudOptions;