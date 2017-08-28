using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Prism.Logging;
using Prism.Modularity;
using Prism.Unity;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorBootstrapper bootstrapper = new CalculatorBootstrapper();
            bootstrapper.Run();
        }
    }
}