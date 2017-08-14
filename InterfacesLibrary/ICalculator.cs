namespace Application
{
    public interface ICalculator
    {
        int Add(Arguments args);
        int Div(Arguments args);
        int Execute(CommandType commandType, Arguments args);
        int Mul(Arguments args);
        int Sub(Arguments args);
    }
}