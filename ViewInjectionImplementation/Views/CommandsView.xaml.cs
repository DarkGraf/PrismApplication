using System.Windows.Controls;
using ViewInjectionImplementation.ViewModels;

namespace ViewInjectionImplementation.Views
{
    /// <summary>
    /// Interaction logic for CommandsView.xaml
    /// </summary>
    public partial class CommandsView : UserControl
    {
        public CommandsView(CommandsViewModel viewModel)
        {
            InitializeComponent();
            Loaded += (s, e) =>
            {
                DataContext = viewModel;
            };
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}