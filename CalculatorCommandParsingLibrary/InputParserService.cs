using System;

namespace Application
{
    public class InputParserService
    {
        public CommandType ParseCommand(string command)
        {
            return (CommandType)Enum.Parse(typeof(CommandType), command);
        }
    }
}