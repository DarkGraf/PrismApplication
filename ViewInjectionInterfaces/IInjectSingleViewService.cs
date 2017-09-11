using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ViewInjectionInterfaces
{
    public interface IInjectSingleViewService : INotifyPropertyChanged
    {
        IEnumerable<CommandViewDefinition> Commands { get; }
        void RegisterViewForRegion(string commandName, string viewName, string regionName, Type viewType);

        void ClearViewFromRegion(string viewName, string regionName);
    }
}