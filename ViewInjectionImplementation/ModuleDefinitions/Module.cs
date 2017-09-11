using System;
using Prism.Modularity;
using Microsoft.Practices.Unity;
using ViewInjectionInterfaces;
using ViewInjectionImplementation.Services;
using Prism.Regions;
using ViewInjectionImplementation.Views;

namespace ViewInjectionImplementation.ModuleDefinitions
{
    public class Module : IModule
    {
        IUnityContainer container;
        IRegionManager regionManager;

        public Module(IUnityContainer container, IRegionManager regionManager)
        {
            this.container = container;
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            container.RegisterType<IInjectSingleViewService, InjectSingleViewService>(new ContainerControlledLifetimeManager());

            regionManager.RegisterViewWithRegion("CommandsRegion", typeof(CommandsView));
        }
    }
}