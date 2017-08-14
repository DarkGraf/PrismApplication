using System;

namespace Application
{
    public class InputParserService : IInputParserService
    {
        public CommandType ParseCommand(string command)
        {
            return (CommandType)Enum.Parse(typeof(CommandType), command);
        }
    }
}