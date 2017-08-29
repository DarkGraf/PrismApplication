using System.Windows;

namespace MyWpfApplication
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MyBootstrapper bootstrapper = new MyBootstrapper();
            bootstrapper.Run();
        }
    }
}