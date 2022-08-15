using System.Windows;
using System.Windows.Controls;

namespace GitLabExtension
{
    public partial class MergeRequestToolWindowControl : UserControl
    {
        public MergeRequestToolWindowControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            VS.MessageBox.Show("MergeRequestToolWindowControl", "Button clicked");
        }
    }
}
