using Microsoft.Practices.Unity;
using Prism.Modularity;

namespace Application
{
    public class CalculatorModule : IModule
    {
        IUnityContainer container;

        public CalculatorModule(IUnityContainer container)
        {
            this.container = container;
        }

        public void Initialize()
        {
            container.RegisterType<ICalculator, Calculator>();
            container.RegisterType<ICalculatorReplLoop, CalculatorReplLoop>();
        }
    }
}