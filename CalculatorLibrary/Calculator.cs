using System;

namespace Application
{
    public class Calculator : ICalculator
    {
        public int Execute(CommandType commandType, Arguments args)
        {
            switch (commandType)
            {
                case CommandType.Add:
                    return Add(args);
                case CommandType.Sub:
                    return Sub(args);
                case CommandType.Mul:
                    return Mul(args);
                case CommandType.Div:
                    return Div(args);
                default:
                    throw new InvalidOperationException();
            }
        }

        public int Add(Arguments args)
        {
            return args.X + args.Y;
        }

        public int Sub(Arguments args)
        {
            return args.X - args.Y;
        }

        public int Mul(Arguments args)
        {
            return args.X * args.Y;
        }

        public int Div(Arguments args)
        {
            return args.X / args.Y;
        }
    }
}