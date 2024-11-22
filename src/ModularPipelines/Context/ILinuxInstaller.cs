using ModularPipelines.Models;
using ModularPipelines.Options.Linux.Dpkg;

namespace ModularPipelines.Context;

public interface ILinuxInstaller
{
    Task<CommandResult> InstallFromDpkg(DpkgInstallOptions options);
}