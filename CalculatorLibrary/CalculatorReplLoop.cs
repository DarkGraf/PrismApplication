using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;

namespace Application
{
    public class CalculatorReplLoop : ICalculatorReplLoop
    {
        public CalculatorReplLoop(IUnityContainer container, ICalculator calculator, 
            IInputService inputService, IInputParserService parsingService)
        {
            this.calculator = calculator;
            this.inputService = inputService;
            this.parsingService = parsingService;

            outputServices = new List<IOutputService>(container.ResolveAll<IOutputService>());
        }

        ICalculator calculator;
        IInputService inputService;
        List<IOutputService> outputServices;
        IInputParserService parsingService;

        public void Run()
        {
            while (true)
            {
                string command = inputService.ReadCommand();

                try
                {
                    CommandType commandType = parsingService.ParseCommand(command);

                    Arguments args = inputService.ReadArguments();

                    WriteMessageToAllOutputServices(calculator.Execute(commandType, args).ToString());
                }
                catch 
                {
                    WriteMessageToAllOutputServices("Mistake!");
                }
            }
        }

        void WriteMessageToAllOutputServices(string message)
        {
            foreach (IOutputService outputService in outputServices)
            {
                outputService.WriteMessage(message);
            }
        }
    }
}