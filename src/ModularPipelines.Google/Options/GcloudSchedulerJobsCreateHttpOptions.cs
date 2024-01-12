using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Models;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("scheduler", "jobs", "create", "http")]
public record GcloudSchedulerJobsCreateHttpOptions(
[property: PositionalArgument] string Job,
[property: PositionalArgument] string Location,
[property: CommandSwitch("--schedule")] string Schedule,
[property: CommandSwitch("--uri")] string Uri
) : GcloudOptions
{
    [CommandSwitch("--attempt-deadline")]
    public string? AttemptDeadline { get; set; }

    [CommandSwitch("--description")]
    public string? Description { get; set; }

    [CommandSwitch("--headers")]
    public IEnumerable<KeyValue>? Headers { get; set; }

    [CommandSwitch("--http-method")]
    public string? HttpMethod { get; set; }

    [CommandSwitch("--max-backoff")]
    public string? MaxBackoff { get; set; }

    [CommandSwitch("--max-doublings")]
    public string? MaxDoublings { get; set; }

    [CommandSwitch("--max-retry-attempts")]
    public string? MaxRetryAttempts { get; set; }

    [CommandSwitch("--max-retry-duration")]
    public string? MaxRetryDuration { get; set; }

    [CommandSwitch("--min-backoff")]
    public string? MinBackoff { get; set; }

    [CommandSwitch("--time-zone")]
    public string? TimeZone { get; set; }

    [CommandSwitch("--message-body")]
    public string? MessageBody { get; set; }

    [CommandSwitch("--message-body-from-file")]
    public string? MessageBodyFromFile { get; set; }

    [CommandSwitch("--oauth-service-account-email")]
    public string? OauthServiceAccountEmail { get; set; }

    [CommandSwitch("--oauth-token-scope")]
    public string? OauthTokenScope { get; set; }

    [CommandSwitch("--oidc-service-account-email")]
    public string? OidcServiceAccountEmail { get; set; }

    [CommandSwitch("--oidc-token-audience")]
    public string? OidcTokenAudience { get; set; }
}