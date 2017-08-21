using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Prism.Unity;
using System;
using System.Configuration;
using System.Linq;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();

            container.LoadConfiguration();
            container.RegisterInstance<IServiceLocator>(new UnityServiceLocatorAdapter(container));

            ICalculatorReplLoop loop = container.Resolve<ICalculatorReplLoop>();
            loop.Run();
        }
    }
}