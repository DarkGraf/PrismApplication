using System;
using System.Collections.Generic;
using System.Linq;
using PresentationUtility.PropertyChanged;
using ViewInjectionInterfaces;
using Prism.Regions;
using Prism.Commands;
using Microsoft.Practices.Unity;

namespace ViewInjectionImplementation.Services
{
    public class InjectSingleViewService : PropertyChangedImplementation, IInjectSingleViewService
    {
        IRegionManager regionManager;
        IUnityContainer container;
        List<CommandViewDefinition> commands;

        public InjectSingleViewService(IRegionManager regionManager, IUnityContainer unityContainer)
        {
            this.regionManager = regionManager;
            this.container = unityContainer;
            commands = new List<CommandViewDefinition>();
        }

        public IEnumerable<CommandViewDefinition> Commands
        {
            get { return commands.AsReadOnly(); }
        }

        public void RegisterViewForRegion(string commandName, string viewName, string regionName, Type viewType)
        {
            CommandViewDefinition definition = new CommandViewDefinition
            {
                CommandName = commandName,
                Command = new DelegateCommand<object>(o =>
                {
                    object view = container.Resolve(viewType);
                    IRegion region = regionManager.Regions[regionName];
                    region.Add(view, viewName);
                    region.Activate(view);
                })
            };

            commands.Add(definition);
            FirePropertyChanged("Commands");
        }

        public void ClearViewFromRegion(string viewName, string regionName)
        {
            IRegion region = regionManager.Regions[regionName];
            object view = region.GetView(viewName);
            region.Remove(view);
            region.Activate(region.Views.First());
        }
    }
}