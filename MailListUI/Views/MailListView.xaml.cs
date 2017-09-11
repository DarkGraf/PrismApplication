using MailListUI.ViewModels;
using System.Windows.Controls;

namespace MailListUI.Views
{
    /// <summary>
    /// Interaction logic for MailListView.xaml
    /// </summary>
    public partial class MailListView : UserControl
    {
        public MailListView(MailListViewModel viewModel)
        {
            InitializeComponent();

            Loaded += (s, e) =>
            {
                DataContext = viewModel;
            };
        }
    }
}