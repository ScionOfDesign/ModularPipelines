﻿using ModularPipelines.Attributes;

namespace ModularPipelines.Kubernetes.Options;

[CommandPrecedingArguments("apply")]
public record KubernetesApplyOptions : KubernetesOptions
{
    [BooleanCommandSwitch("all")]
    public bool? All { get; set; }

    [BooleanCommandSwitch("allow-missing-template-keys")]
    public bool? AllowMissingTemplateKeys { get; set; }

    [CommandLongSwitch("cascade", SwitchValueSeparator = " ")]
    public string? Cascade { get; set; }

    [CommandLongSwitch("dry-run", SwitchValueSeparator = " ")]
    public string? DryRun { get; set; }

    [CommandLongSwitch("field-manager", SwitchValueSeparator = " ")]
    public string? FieldManager { get; set; }

    [CommandLongSwitch("filename", SwitchValueSeparator = " ")]
    public string[]? Filename { get; set; }

    [BooleanCommandSwitch("force")]
    public bool? Force { get; set; }

    [BooleanCommandSwitch("force-conflicts")]
    public bool? ForceConflicts { get; set; }

    [CommandLongSwitch("grace-period", SwitchValueSeparator = " ")]
    public int? GracePeriod { get; set; }

    [CommandLongSwitch("kustomize", SwitchValueSeparator = " ")]
    public string? Kustomize { get; set; }

    [BooleanCommandSwitch("openapi-patch")]
    public bool? OpenapiPatch { get; set; }

    [CommandLongSwitch("output", SwitchValueSeparator = " ")]
    public string? Output { get; set; }

    [BooleanCommandSwitch("overwrite")]
    public bool? Overwrite { get; set; }

    [BooleanCommandSwitch("prune")]
    public bool? Prune { get; set; }

    [CommandLongSwitch("prune-whitelist", SwitchValueSeparator = " ")]
    public string[]? PruneWhitelist { get; set; }

    [BooleanCommandSwitch("record")]
    public bool? Record { get; set; }

    [BooleanCommandSwitch("recursive")]
    public bool? Recursive { get; set; }

    [CommandLongSwitch("selector", SwitchValueSeparator = " ")]
    public string? Selector { get; set; }

    [BooleanCommandSwitch("server-side")]
    public bool? ServerSide { get; set; }

    [BooleanCommandSwitch("show-managed-fields")]
    public bool? ShowManagedFields { get; set; }

    [CommandLongSwitch("template", SwitchValueSeparator = " ")]
    public string? Template { get; set; }

    [CommandLongSwitch("timeout", SwitchValueSeparator = " ")]
    public string? Timeout { get; set; }

    [BooleanCommandSwitch("validate")]
    public bool? Validate { get; set; }

    [BooleanCommandSwitch("wait")]
    public bool? Wait { get; set; }

}
