using MailReadingUI.ViewModels;
using System.Windows.Controls;

namespace MailReadingUI.Views
{
    /// <summary>
    /// Interaction logic for MailReadingView.xaml
    /// </summary>
    public partial class MailReadingView : UserControl
    {
        public MailReadingView(MailReadingViewModel viewModel)
        {
            InitializeComponent();

            Loaded += (s, e) =>
            {
                DataContext = viewModel;
            };
        }
    }
}