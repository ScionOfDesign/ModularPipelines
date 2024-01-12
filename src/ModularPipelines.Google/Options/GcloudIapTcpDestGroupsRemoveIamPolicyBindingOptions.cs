using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Models;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("iap", "tcp", "dest-groups", "remove-iam-policy-binding")]
public record GcloudIapTcpDestGroupsRemoveIamPolicyBindingOptions(
[property: CommandSwitch("--dest-group")] string DestGroup,
[property: CommandSwitch("--member")] string Member,
[property: CommandSwitch("--region")] string Region,
[property: CommandSwitch("--role")] string Role
) : GcloudOptions
{
    [BooleanCommandSwitch("--all")]
    public bool? All { get; set; }

    [CommandSwitch("--condition")]
    public IEnumerable<KeyValue>? Condition { get; set; }

    [BooleanCommandSwitch("expression")]
    public bool? Expression { get; set; }

    [BooleanCommandSwitch("title")]
    public bool? Title { get; set; }

    [BooleanCommandSwitch("description")]
    public bool? Description { get; set; }

    [CommandSwitch("--condition-from-file")]
    public string? ConditionFromFile { get; set; }
}