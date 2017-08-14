namespace Application
{
    public interface IInputParserService
    {
        CommandType ParseCommand(string command);
    }
}