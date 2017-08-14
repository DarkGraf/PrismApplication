using System;

namespace Application
{
    public class CalculatorReplLoop
    {
        public CalculatorReplLoop()
        {
            Calculator = new Calculator();
            InputService = new ConsoleInputService();
            OutputService = new ConsoleOutputService();
            ParsingService = new InputParserService();
        }

        public ICalculator Calculator { get; set; }
        public IInputService InputService { get; set; }
        public IOutputService OutputService { get; set; }
        public IInputParserService ParsingService { get; set; }

        public void Run()
        {
            while (true)
            {
                string command = InputService.ReadCommand();

                try
                {
                    CommandType commandType = ParsingService.ParseCommand(command);

                    Arguments args = InputService.ReadArguments();

                    OutputService.WriteMessage(Calculator.Execute(commandType, args).ToString());
                }
                catch 
                {
                    OutputService.WriteMessage("Mistake!");
                }
            }
        }
    }
}