using PresentationUtility.PropertyChanged;
using System.Collections.Generic;
using ViewInjectionInterfaces;

namespace ViewInjectionImplementation.ViewModels
{
    public class CommandsViewModel : PropertyChangedImplementation
    {
        IInjectSingleViewService viewService;

        public CommandsViewModel(IInjectSingleViewService viewService)
        {
            this.viewService = viewService;
            viewService.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == "Commands")
                {
                    FirePropertyChanged("Commands");
                }
            };
        }
        public IEnumerable<CommandViewDefinition> Commands
        {
            get { return viewService.Commands; }
        }
    }
}