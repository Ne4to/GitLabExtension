using Microsoft.VisualStudio.Imaging;

using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace GitLabExtension
{
    public class MergeRequestToolWindow : BaseToolWindow<MergeRequestToolWindow>
    {
        public override string GetTitle(int toolWindowId) => "Merge Request";

        public override Type PaneType => typeof(Pane);

        public override Task<FrameworkElement> CreateAsync(int toolWindowId, CancellationToken cancellationToken)
        {
            return Task.FromResult<FrameworkElement>(new MergeRequestToolWindowControl());
        }

        [Guid("438b1cc8-21a1-46ab-b264-9e8c7a8821b8")]
        internal class Pane : ToolWindowPane
        {
            public Pane()
            {
                BitmapImageMoniker = KnownMonikers.ToolWindow;
            }
        }
    }
}
