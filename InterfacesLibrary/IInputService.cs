namespace Application
{
    public interface IInputService
    {
        Arguments ReadArguments();
        string ReadCommand();
    }
}