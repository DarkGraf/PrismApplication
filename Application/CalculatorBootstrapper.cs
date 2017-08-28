using Prism.Unity;
using System.Windows;
using Prism.Modularity;

namespace Application
{
    class CalculatorBootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return null;
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }
    }
}