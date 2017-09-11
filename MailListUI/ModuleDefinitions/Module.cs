using System;
using Prism.Modularity;
using Prism.Regions;
using MailListUI.Views;

namespace MailListUI.ModuleDefinitions
{
    public class Module : IModule
    {
        IRegionManager regionManager;

        public Module(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MailSelectionRegion", typeof(MailListView));
        }
    }
}