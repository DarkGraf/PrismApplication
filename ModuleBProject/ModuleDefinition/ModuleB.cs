using System;
using InterfacesProject;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleBProject
{
    public class ModuleB : IModule
    {
        IUnityContainer container;
        IRegionManager regionManager;

        public ModuleB(IUnityContainer container, IRegionManager regionManager)
        {
            this.container = container;
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            RegisterViews();
        }

        private void RegisterViews()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(ModuleBViewOne));
        }
    }
}