using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Terraform.Options;

[CommandPrecedingArguments("init")]
[ExcludeFromCodeCoverage]
public record TerraformInitOptions : TerraformPlanOptions
{
    [BooleanCommandSwitch("-upgrade")]
    public bool? Upgrade { get; set; }

    [CommandSwitch("-from-module")]
    public string? FromModule { get; set; }

    [BooleanCommandSwitch("-reconfigure")]
    public bool? Reconfigure { get; set; }

    [BooleanCommandSwitch("-migrate-state")]
    public bool? MigrateState { get; set; }

    [BooleanCommandSwitch("-force-copy")]
    public bool? ForceCopy { get; set; }

    [BooleanCommandSwitch("-backend")]
    public bool? Backend { get; set; }

    [CommandSwitch("-backend-config")]
    public string? BackendConfig { get; set; }

    [BooleanCommandSwitch("-get")]
    public bool? Get { get; set; }

    [BooleanCommandSwitch("-get-plugins")]
    public bool? GetPlugins { get; set; }

    [CommandSwitch("-plugin-dir")]
    public string? PluginDir { get; set; }

    [CommandSwitch("-lockfile")]
    public string? Lockfile { get; set; }
}