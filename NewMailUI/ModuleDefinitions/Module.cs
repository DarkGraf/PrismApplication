using System;
using Prism.Modularity;
using Prism.Regions;
using ViewInjectionInterfaces;
using NewMailUI.Views;

namespace NewMailUI.ModuleDefinitions
{
    public class Module : IModule
    {
        IInjectSingleViewService InjectViewService;

        public Module(IInjectSingleViewService InjectViewService)
        {
            this.InjectViewService = InjectViewService;
        }

        public void Initialize()
        {
            InjectViewService.RegisterViewForRegion("New Email", "NewEmailView", "MainRegion", typeof(NewMailView));
        }
    }
}