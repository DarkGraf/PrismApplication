using InterfacesProject;
using Microsoft.Practices.Unity;
using Prism.Modularity;

namespace ModuleBProject
{
    public class ModuleB : IModule
    {
        IUnityContainer container;

        public ModuleB(IUnityContainer container)
        {
            this.container = container;
        }

        public void Initialize()
        {
            container.RegisterType<IUIService, UIService>();
        }
    }
}