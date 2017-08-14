using System;

namespace Application
{
    public class ConsoleInputService : IInputService
    {
        public string ReadCommand()
        {
            return Console.ReadLine();
        }

        public Arguments ReadArguments()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            return new Arguments
            {
                X = x,
                Y = y
            };
        }
    }
}