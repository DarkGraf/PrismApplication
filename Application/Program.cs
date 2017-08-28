using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Prism.Logging;
using Prism.Modularity;
using Prism.Unity;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();
            container.RegisterInstance<IServiceLocator>(new UnityServiceLocatorAdapter(container));

            container.RegisterType<IModuleInitializer, ModuleInitializer>();

            TextLogger logger = new TextLogger();
            container.RegisterInstance<ILoggerFacade>(logger);

            ConfigurationModuleCatalog catalog = new ConfigurationModuleCatalog();
            container.RegisterInstance<IModuleCatalog>(catalog);

            container.RegisterType<IModuleManager, ModuleManager>();

            IModuleManager manager = container.Resolve<IModuleManager>();
            manager.Run();
        }
    }
}