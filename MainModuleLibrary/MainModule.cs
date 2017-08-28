using System;
using Prism.Modularity;
using Microsoft.Practices.ServiceLocation;

namespace Application
{
    public class MainModule : IModule
    {
        IServiceLocator serviceLocator;

        public MainModule(IServiceLocator serviceLocator)
        {
            this.serviceLocator = serviceLocator;
        }

        public void Initialize()
        {
            ICalculatorReplLoop loop = serviceLocator.GetInstance<ICalculatorReplLoop>();
            loop.Run();
        }
    }
}