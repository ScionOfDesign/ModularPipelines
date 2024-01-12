using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("network-services", "endpoint-policies", "describe")]
public record GcloudNetworkServicesEndpointPoliciesDescribeOptions(
[property: PositionalArgument] string EndpointPolicy,
[property: PositionalArgument] string Location
) : GcloudOptions;