global using Community.VisualStudio.Toolkit;

global using Microsoft.VisualStudio.Shell;

global using System;

global using Task = System.Threading.Tasks.Task;

using System.Runtime.InteropServices;
using System.Threading;

namespace GitLabExtension
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration(Vsix.Name, Vsix.Description, Vsix.Version)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(PackageGuids.GitLabExtensionString)]
    [ProvideToolWindow(typeof(MergeRequestToolWindow.Pane), Style = VsDockStyle.Linked, Window = WindowGuids.SolutionExplorer)]
    [ProvideOptionPage(typeof(OptionsProvider.GeneralOptions), "GitLab Merge request", "General", 0, 0, true, SupportsProfiles = true)]
    [ProvideProfile(typeof(OptionsProvider.GeneralOptions), "GitLab Merge request", "General", 0, 0, true)]
    public sealed class GitLabExtensionPackage : ToolkitPackage
    {
        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            await this.RegisterCommandsAsync();
            this.RegisterToolWindows();
        }
    }
}