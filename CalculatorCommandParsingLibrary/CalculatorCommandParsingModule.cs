using Microsoft.Practices.Unity;
using Prism.Modularity;

namespace Application
{
    public class CalculatorCommandParsingModule : IModule
    {
        IUnityContainer container;

        public CalculatorCommandParsingModule(IUnityContainer container)
        {
            this.container = container;
        }

        public void Initialize()
        {
            container.RegisterType<IInputParserService, InputParserService>();
        }
    }
}