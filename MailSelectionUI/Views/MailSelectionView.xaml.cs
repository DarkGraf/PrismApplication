using MailSelectionUI.ViewModels;
using System.Windows.Controls;

namespace MailSelectionUI.Views
{
    /// <summary>
    /// Interaction logic for MailSelectionView.xaml
    /// </summary>
    public partial class MailSelectionView : UserControl
    {
        public MailSelectionView(MailSelectionViewModel viewModel)
        {
            InitializeComponent();

            Loaded += (s, e) =>
            {
                DataContext = viewModel;
            };
        }
    }
}