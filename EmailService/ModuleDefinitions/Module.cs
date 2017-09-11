using System;
using Prism.Modularity;
using Microsoft.Practices.Unity;
using EmailInterfaces;

namespace EmailService.ModuleDefinitions
{
    public class Module : IModule
    {
        IUnityContainer container;

        public Module(IUnityContainer container)
        {
            this.container = container;
        }

        public void Initialize()
        {
            container.RegisterInstance<IEmailService>(new Services.EmailService());
        }
    }
}