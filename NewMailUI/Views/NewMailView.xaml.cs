using NewMailUI.ViewModels;
using System.Windows.Controls;

namespace NewMailUI.Views
{
    /// <summary>
    /// Interaction logic for NewMailView.xaml
    /// </summary>
    public partial class NewMailView : UserControl
    {
        public NewMailView(NewMailViewModel viewModel)
        {
            InitializeComponent();

            Loaded += (s, e) =>
            {
                this.DataContext = viewModel;
            };
        }
    }
}