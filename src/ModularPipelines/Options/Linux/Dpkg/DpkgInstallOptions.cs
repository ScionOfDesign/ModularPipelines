using System.Diagnostics.CodeAnalysis;

namespace ModularPipelines.Options.Linux.Dpkg;

[ExcludeFromCodeCoverage]
public record DpkgInstallOptions : DpkgOptions
{
    public DpkgInstallOptions(string path) : base()
    {
        InstallPackage = path;
        Sudo = true;
    }
}