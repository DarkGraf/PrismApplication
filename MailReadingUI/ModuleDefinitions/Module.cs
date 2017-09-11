using System;
using Prism.Modularity;
using Prism.Regions;
using MailReadingUI.Views;

namespace MailReadingUI.ModuleDefinitions
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
            regionManager.RegisterViewWithRegion("MailReaderRegion", typeof(MailReadingView));
        }
    }
}