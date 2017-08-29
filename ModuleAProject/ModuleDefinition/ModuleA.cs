using System;
using InterfacesProject;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleAProject
{
    public class ModuleA : IModule
    {
        IUnityContainer container;
        IRegionManager regionManager;

        public ModuleA(IUnityContainer container, IRegionManager regionManager)
        {
            this.container = container;
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            RegisterServices();
            RegisterViews();
        }

        private void RegisterServices()
        {
            container.RegisterType<ITextService, TextService>();
        }

        private void RegisterViews()
        {
            regionManager.RegisterViewWithRegion("ListRegion", typeof(ModuleAViewOne));
            regionManager.RegisterViewWithRegion("ListRegion", typeof(ModuleAViewTwo));
        }
    }
}