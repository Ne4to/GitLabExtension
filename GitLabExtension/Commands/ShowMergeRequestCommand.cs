namespace GitLabExtension
{
    [Command(PackageIds.ShowMergeRequest)]
    internal sealed class ShowMergeRequestCommand : BaseCommand<ShowMergeRequestCommand>
    {
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            await MergeRequestToolWindow.ShowAsync();
            //await VS.MessageBox.ShowWarningAsync("GitLabExtension", "Button clicked");

            //var docView = await VS.Documents.GetActiveDocumentViewAsync();
            //var selection = docView.TextView.Selection.SelectedSpans.FirstOrDefault();

            //if (selection != null)
            //{
            //    docView.TextBuffer.Replace(selection, Guid.NewGuid().ToString());
            //}
        }
    }
}
