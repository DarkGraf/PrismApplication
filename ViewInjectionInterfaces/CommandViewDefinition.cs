using System.Windows.Input;

namespace ViewInjectionInterfaces
{
    public class CommandViewDefinition
    {
        public string CommandName { get; set; }
        public ICommand Command { get; set; }
    }
}