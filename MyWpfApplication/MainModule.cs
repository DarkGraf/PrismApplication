using InterfacesProject;
using Microsoft.Practices.Unity;
using Prism.Modularity;

namespace MyWpfApplication
{
    public class MainModule : IModule
    {
        IUnityContainer container;

        public MainModule(IUnityContainer container)
        {
            this.container = container;
        }

        public void Initialize()
        {
            IUIService uiService = container.Resolve<IUIService>();
            App.Current.MainWindow.Content = uiService.GetUI();
        }
    }
}