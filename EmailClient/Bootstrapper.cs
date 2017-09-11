using EmailClient.Views;
using EmailInterfaces;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using System.Windows;

namespace EmailClient
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }

        protected override DependencyObject CreateShell()
        {
            Shell shell = new Shell();
            shell.Show();
            UIDispatcher dispatcher = new UIDispatcher(Application.Current.MainWindow.Dispatcher);
            Container.RegisterInstance<IDispatcherService>(dispatcher);

            IRegionManager regionManager = Container.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("MainRegion", typeof(MainView));

            return shell;
        }
    }
}