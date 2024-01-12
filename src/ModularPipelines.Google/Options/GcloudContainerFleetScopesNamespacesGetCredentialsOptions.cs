using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("container", "fleet", "scopes", "namespaces", "get-credentials")]
public record GcloudContainerFleetScopesNamespacesGetCredentialsOptions(
[property: PositionalArgument] string Namespace
) : GcloudOptions
{
    [CommandSwitch("--membership")]
    public string? Membership { get; set; }

    [CommandSwitch("--membership-location")]
    public string? MembershipLocation { get; set; }

    [CommandSwitch("--set-namespace-in-config")]
    public string? SetNamespaceInConfig { get; set; }
}