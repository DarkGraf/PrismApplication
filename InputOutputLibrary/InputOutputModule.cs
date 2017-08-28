using Microsoft.Practices.Unity;
using Prism.Modularity;

namespace Application
{
    public class InputOutputModule : IModule
    {
        IUnityContainer container;

        public InputOutputModule(IUnityContainer container)
        {
            this.container = container;
        }

        public void Initialize()
        {
            container.RegisterType<IInputService, ConsoleInputService>();
            container.RegisterType<IOutputService, ConsoleOutputService>("OutputService1");
            container.RegisterType<IOutputService, MsgBoxOutputService>("OutputService2");
        }
    }
}