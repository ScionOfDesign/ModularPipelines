using ModularPipelines.Attributes;

namespace ModularPipelines.Node.Models;

[CommandPrecedingArguments("ci")]
public record NpmCleanInstallOptions(string Target) : NpmOptions
{
    [CommandLongSwitch("install-strategy")]
    public string? InstallStrategy { get; init; }

    [CommandLongSwitch("omit")]
    public IEnumerable<string>? Omit { get; init; }
}
