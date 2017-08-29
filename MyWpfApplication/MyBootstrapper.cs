using Prism.Modularity;
using Prism.Unity;
using System.Windows;

namespace MyWpfApplication
{
    class MyBootstrapper : UnityBootstrapper
    {
        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }

        protected override DependencyObject CreateShell()
        {
            Shell shell = new Shell();
            shell.Show();
            return shell;
        }
    }
}