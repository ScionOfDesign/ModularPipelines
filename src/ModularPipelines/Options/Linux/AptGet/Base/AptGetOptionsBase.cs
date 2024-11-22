using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Options.Linux.AptGet;

#pragma warning disable SA1623 // Property summary documentation should match accessors
#pragma warning disable SA1629 // Property summary documentation should match accessors
[ExcludeFromCodeCoverage]
public abstract record AptGetOptionsBase : CommandLineToolOptions
{
    protected AptGetOptionsBase() : base("apt-get")
    {
        Sudo = true;
    }

    /// <summary>
    /// Do not consider recommended packages as a dependency for installing.
    /// </summary>
    [BooleanCommandSwitch("--no-install-recommends")]
    public bool? NoInstallRecommends { get; set; }

    /// <summary>
    /// Consider suggested packages as a dependency for installing.
    /// </summary>
    [BooleanCommandSwitch("--install-suggests")]
    public bool? InstallSuggests { get; set; }

    /// <summary>
    /// Download only; package files are only retrieved, not unpacked or installed.
    /// </summary>
    [BooleanCommandSwitch("--download-only")]
    public bool? DownloadOnly { get; set; }

    /// <summary>
    /// Fix broken dependencies.
    /// </summary>
    [BooleanCommandSwitch("--fix-broken")]
    public bool? FixBroken { get; set; }

    /// <summary>
    /// Ignore missing packages; if packages cannot be retrieved or fail the integrity check after retrieval
    /// (corrupted package files), hold back those packages and handle the result.
    /// </summary>
    [BooleanCommandSwitch("--ignore-missing")]
    public bool? IgnoreMissing { get; set; }

    /// <summary>
    /// Disables downloading of packages. This is best used with --ignore-missing to force APT to use only the
    /// .debs it has already downloaded.
    /// </summary>
    [BooleanCommandSwitch("--no-download")]
    public bool? NoDownload { get; set; }

    /// <summary>
    /// Quiet; produces output suitable for logging, omitting progress indicators.
    /// </summary>
    [BooleanCommandSwitch("--quiet")]
    public bool? Quiet { get; set; }

    /// <summary>
    /// No action; perform a simulation of events that would occur based on the current system state but do not
    /// actually change the system.
    /// </summary>
    [BooleanCommandSwitch("--simulate")]
    public bool? Simulate { get; set; }

    /// <summary>
    /// Automatic yes to prompts; assume "yes" as answer to all prompts and run non-interactively.
    /// </summary>
    [BooleanCommandSwitch("--assume-yes")]
    public bool? AssumeYes { get; set; } = true;

    /// <summary>
    /// Automatic "no" to all prompts.
    /// </summary>
    [BooleanCommandSwitch("--assume-no")]
    public bool? AssumeNo { get; set; }

    /// <summary>
    /// Do not show a list of all packages that are to be upgraded.
    /// </summary>
    [BooleanCommandSwitch("--no-show-upgraded")]
    public bool? NoShowUpgraded { get; set; }

    /// <summary>
    /// Show full versions for upgraded and installed packages.
    /// </summary>
    [BooleanCommandSwitch("--verbose-versions")]
    public bool? VerboseVersions { get; set; }

    /// <summary>
    /// This option controls the architecture packages are built for by apt-get source --compile and how
    /// cross-builddependencies are satisfied. By default is it not set which means that the host architecture is
    /// the same as the build architecture (which is defined by APT::Architecture).
    /// </summary>
    [CommandSwitch("--host-architecture")]
    public string? HostArchitecture { get; set; }

    /// <summary>
    /// This option controls the activated build profiles for which a source package is built by apt-get source
    /// --compile and how build dependencies are satisfied. By default no build profile is active. More than one
    /// build profile can be activated at a time by concatenating them with a comma.
    /// </summary>
    [CommandSwitch("--build-profiles")]
    public string? BuildProfiles { get; set; }

    /// <summary>
    /// Compile source packages after downloading them.
    /// </summary>
    [BooleanCommandSwitch("--compile")]
    public bool? Compile { get; set; }

    /// <summary>
    /// Ignore package holds; this causes apt-get to ignore a hold placed on a package.
    /// </summary>
    [BooleanCommandSwitch("--ignore-hold")]
    public bool? IgnoreHold { get; set; }

    /// <summary>
    /// Allow installing new packages when used in conjunction with upgrade.
    /// </summary>
    [BooleanCommandSwitch("--with-new-pkgs")]
    public bool? WithNewPkgs { get; set; }

    /// <summary>
    /// Do not upgrade packages; when used in conjunction with install, no-upgrade will prevent packages on the
    /// command line from being upgraded if they are already installed.
    /// </summary>
    [BooleanCommandSwitch("--no-upgrade")]
    public bool? NoUpgrade { get; set; }

    /// <summary>
    /// Do not install new packages; when used in conjunction with install, only-upgrade will install upgrades for
    /// already installed packages only and ignore requests to install new packages.
    /// </summary>
    [BooleanCommandSwitch("--only-upgrade")]
    public bool? OnlyUpgrade { get; set; }

    /// <summary>
    /// This is a dangerous option that will cause apt to continue without prompting if it is doing downgrades.
    /// </summary>
    [BooleanCommandSwitch("--allow-downgrades")]
    public bool? AllowDowngrades { get; set; }

    /// <summary>
    /// Force yes; this is a dangerous option that will cause apt to continue without prompting if it is removing essentials.
    /// It should not be used except in very special situations. Using it can potentially destroy your system!
    /// </summary>
    [BooleanCommandSwitch("--allow-remove-essential")]
    public bool? AllowRemoveEssential { get; set; }

    /// <summary>
    /// Force yes; this is a dangerous option that will cause apt to continue without prompting if it is changing held packages.
    /// It should not be used except in very special situations. Using it can potentially destroy your system!
    /// </summary>
    [BooleanCommandSwitch("--allow-change-held-packages")]
    public bool? AllowChangeHeldPackages { get; set; }

    /// <summary>
    /// Instead of fetching the files to install their URIs are printed. Each URI will have the path, the
    /// destination file name, the size and the expected MD5 hash. Note that the file name to write to will not
    /// always match the file name on the remote site! This also works with the source and update commands. When
    /// used with the update command the MD5 and size are not included, and it is up to the user to decompress any
    /// compressed files.
    /// </summary>
    [BooleanCommandSwitch("--print-uris")]
    public bool? PrintUris { get; set; }

    /// <summary>
    /// Purge; Purge is identical to remove except that packages are removed and purged (any configuration files are deleted too).
    /// </summary>
    [BooleanCommandSwitch("--purge")]
    public bool? Purge { get; set; }

    /// <summary>
    /// Re-install packages that are already installed and at the newest version.
    /// </summary>
    [BooleanCommandSwitch("--reinstall")]
    public bool? Reinstall { get; set; }

    /// <summary>
    /// When it is off, apt-get will automatically manage the contents of /var/lib/apt/lists to ensure that obsolete files are erased.
    /// The only reason to turn it on is if you frequently change your sources list.
    /// </summary>
    [BooleanCommandSwitch("--no-list-cleanup")]
    public bool? NoListCleanup { get; set; }

    /// <summary>
    /// Default release; This option is used to force the release from which all packages will be installed.
    /// </summary>
    [CommandSwitch("--default-release")]
    public string? DefaultRelease { get; set; }

    /// <summary>
    /// Only perform operations that are 'trivial'. Logically this can be considered related to --assume-yes;
    /// where --assume-yes will answer yes to any prompt, --trivial-only will answer no.
    /// </summary>
    [BooleanCommandSwitch("--trivial-only")]
    public bool? TrivialOnly { get; set; }

    /// <summary>
    /// After successful installation, mark all freshly installed packages as automatically installed, which will
    /// cause each of the packages to be removed when no more manually installed packages depend on this package.
    /// This is equally to running apt-mark auto for all installed packages.
    /// </summary>
    [BooleanCommandSwitch("--mark-auto")]
    public bool? MarkAuto { get; set; }

    /// <summary>
    /// If any packages are to be removed apt-get immediately aborts without prompting.
    /// </summary>
    [BooleanCommandSwitch("--no-remove")]
    public bool? NoRemove { get; set; }

    /// <summary>
    /// If the command is either install or remove, then this option acts like running the autoremove command,
    /// removing unused dependency packages.
    /// </summary>
    [BooleanCommandSwitch("--auto-remove")]
    public bool? AutoRemove { get; set; }

    /// <summary>
    /// Only has meaning for the source and build-dep commands. Indicates that the given source names are not to
    /// be mapped through the binary table. This means that if this option is specified, these commands will only
    /// accept source package names as arguments, rather than accepting binary package names and looking up the
    /// corresponding source package.
    /// </summary>
    [BooleanCommandSwitch("--only-source")]
    public bool? OnlySource { get; set; }

    /// <summary>
    /// Download only the diff source archive.
    /// </summary>
    [BooleanCommandSwitch("--diff-only")]
    public bool? DiffOnly { get; set; }

    /// <summary>
    /// Download only the dsc source archive.
    /// </summary>
    [BooleanCommandSwitch("--dsc-only")]
    public bool? DscOnly { get; set; }

    /// <summary>
    /// Download only the tar source archive.
    /// </summary>
    [BooleanCommandSwitch("--tar-only")]
    public bool? TarOnly { get; set; }

    /// <summary>
    /// Only process architecture-dependent build-dependencies.
    /// </summary>
    [BooleanCommandSwitch("--arch-only")]
    public bool? ArchOnly { get; set; }

    /// <summary>
    /// Only process architecture-independent build-dependencies.
    /// </summary>
    [BooleanCommandSwitch("--indep-only")]
    public bool? IndepOnly { get; set; }

    /// <summary>
    /// Ignore if packages can't be authenticated and don't prompt about it. This can be useful while working with
    /// local repositories, but is a huge security risk if data authenticity isn't ensured in another way by the
    /// user itself. The usage of the Trusted option for sources.list(5) entries should usually be preferred over
    /// this global override.
    /// </summary>
    [BooleanCommandSwitch("--allow-unauthenticated")]
    public bool? AllowUnauthenticated { get; set; }

    /// <summary>
    /// Forbid the update command to acquire unverifiable data from configured sources. APT will fail at the
    /// update command for repositories without valid cryptographically signatures. See also apt-secure(8) for
    /// details on the concept and the implications.
    /// </summary>
    [BooleanCommandSwitch("--no-allow-insecure-repositories")]
    public bool? NoAllowInsecureRepositories { get; set; }

    /// <summary>
    /// Allow the update command to continue downloading data from a repository which changed its information of
    /// the release contained in the repository indicating e.g a new major release. APT will fail at the update
    /// command for such repositories until the change is confirmed to ensure the user is prepared for the change.
    /// See also apt-secure(8) for details on the concept and configuration.
    /// </summary>
    [BooleanCommandSwitch("--allow-releaseinfo-change")]
    public bool? AllowReleaseinfoChange { get; set; }

    /// <summary>
    /// Show user friendly progress information in the terminal window when packages are installed, upgraded or
    /// removed. For a machine parsable version of this data see README.progress-reporting in the apt doc
    /// directory.
    /// </summary>
    [BooleanCommandSwitch("--show-progress")]
    public bool? ShowProgress { get; set; }

    /// <summary>
    /// Adds the given file as a source for metadata. Can be repeated to add multiple files. See --with-source
    /// description in apt-cache(8) for further details.
    /// </summary>
    [CommandSwitch("--with-source")]
    public string[]? WithSource { get; set; }

    /// <summary>
    /// Fail the update command if any error occured, even a transient one.
    /// </summary>
    [BooleanCommandSwitch("--eany")]
    public bool? ErrorOnAny { get; set; }

    /// <summary>
    /// Show a short usage summary.
    /// </summary>
    [BooleanCommandSwitch("--help")]
    public bool? Help { get; set; }

    /// <summary>
    /// Show the program version.
    /// </summary>
    [BooleanCommandSwitch("--version")]
    public bool? Version { get; set; }

    /// <summary>
    /// Config file; This option is used to specify a configuration file to be used instead of the default one.
    /// </summary>
    [CommandSwitch("--config-file")]
    public string? ConfigFile { get; set; }

    /// <summary>
    /// Option; This option is used to set an arbitrary configuration option. The syntax is Foo::Bar=bar.
    /// </summary>
    [CommandSwitch("--option")]
    public string[]? Option { get; set; }
}
#pragma warning restore SA1623 // Property summary documentation should match accessors
#pragma warning restore SA1629 // Property summary documentation should end in a period