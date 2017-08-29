using InterfacesProject;
using Microsoft.Practices.Unity;
using Prism.Modularity;

namespace ModuleAProject
{
    public class ModuleA : IModule
    {
        IUnityContainer container;

        public ModuleA(IUnityContainer container)
        {
            this.container = container;
        }

        public void Initialize()
        {
            container.RegisterType<ITextService, TextService>();
        }
    }
}