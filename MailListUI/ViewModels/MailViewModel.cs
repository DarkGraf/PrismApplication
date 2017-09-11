using EmailEntities;
using PresentationUtility.PropertyChanged;
using Prism.Commands;
using System.Windows.Input;
using System;
using EmailInterfaces;

namespace MailListUI.ViewModels
{
    public class MailViewModel : PropertyChangedImplementation
    {
        Email email;
        IEmailService emailService;
        ICommand expandCommand;
        ICommand deleteCommand;
        bool isExpanded;

        public MailViewModel(Email email, IEmailService emailService) 
        {
            this.email = email;
            this.emailService = emailService;
        }

        public Email Email
        {
            get { return email; }
        }

        public string ButtonText
        {
            get { return IsExpanded ? "-" : "+"; }
        }

        public bool IsExpanded
        {
            get { return isExpanded; }
            set
            {
                isExpanded = value;
                FirePropertyChanged("IsExpanded");
                FirePropertyChanged("ButtonText");
            }
        }

        public ICommand ExpandCommand
        {
            get
            {
                if (expandCommand == null)
                {
                    expandCommand = new DelegateCommand<object>(OnExpandCommandExecuted);
                }
                return expandCommand;
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                if (deleteCommand == null)
                {
                    deleteCommand = new DelegateCommand<object>(OnDeleteCommandExecuted);
                }
                return deleteCommand;
            }
        }

        private void OnExpandCommandExecuted(object arg)
        {
            IsExpanded = !IsExpanded;
        }

        private void OnDeleteCommandExecuted(object arg)
        {
            emailService.DeleteMail(this.email);
        }
    }
}