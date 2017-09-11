using Prism.Modularity;
using Prism.Regions;
using MailSelectionUI.Views;

namespace MailSelectionUI.ModuleDefinitions
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
            regionManager.RegisterViewWithRegion("FolderSelectionRegion", typeof(MailSelectionView));
        }
    }
}