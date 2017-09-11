using EmailEntities;
using Prism.Commands;
using System.Windows.Input;
using System;
using ViewInjectionInterfaces;
using EmailInterfaces;

namespace NewMailUI.ViewModels
{
    public class NewMailViewModel
    {
        IInjectSingleViewService viewService;
        IEmailService emailService;
        Email email;
        ICommand okCommand;
        ICommand cancelCommand;

        public NewMailViewModel(IInjectSingleViewService viewService, IEmailService emailService)
        {
            this.viewService = viewService;
            this.emailService = emailService; 
            email = Email.Create();
        }

        public Email Email
        {
            get { return email; }
        }

        public ICommand OkCommand
        {
            get
            {
                if (okCommand == null)
                {
                    okCommand = new DelegateCommand<object>(OnOkCommand);
                }
                return okCommand;
            }
        }

        public ICommand CancelCommand
        {
            get
            {
                if (cancelCommand == null)
                {
                    cancelCommand = new DelegateCommand<object>(OnCancelCommand);
                }
                return cancelCommand;
            }
        }

        private void OnOkCommand(object o)
        {
            emailService.SendMail(email);
            OnCancelCommand(null);
        }

        private void OnCancelCommand(object obj)
        {
            viewService.ClearViewFromRegion("NewEmailView", "MainRegion");
        }
    }
}