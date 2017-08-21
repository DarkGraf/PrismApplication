using Microsoft.Practices.Unity;
using System;
using System.Linq;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();
            container.RegisterType<ICalculator, Calculator>();
            container.RegisterType<IInputService, ConsoleInputService>();
            container.RegisterType<IOutputService, ConsoleOutputService>();
            container.RegisterType<IInputParserService, InputParserService>();
            container.RegisterType<ICalculatorReplLoop, CalculatorReplLoop>();

            ICalculatorReplLoop loop = container.Resolve<ICalculatorReplLoop>();
            loop.Run();
        }
    }
}