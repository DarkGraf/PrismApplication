using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
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
            //UnityConfigurationSection configSection = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            //configSection.Containers.Default.Configure(container);

            ICalculatorReplLoop loop = container.Resolve<ICalculatorReplLoop>();
            loop.Run();
        }
    }
}