using EmailEntities;
using EmailEntities.CompositeEvents;
using EmailInterfaces;
using Prism.Commands;
using Prism.Events;
using System.Collections.Generic;
using System.Windows.Input;

namespace MailSelectionUI.ViewModels
{
    public class MailSelectionViewModel
    {
        IEmailService emailService;
        IEventAggregator eventAggregator;
        ICommand selectionChangedCommand;

        public MailSelectionViewModel(IEmailService emailService, IEventAggregator eventAggregator)
        {
            this.emailService = emailService;
            this.eventAggregator = eventAggregator;
        }

        public ICommand SelectionChangedCommand
        {
            get
            {
                if (selectionChangedCommand == null)
                {
                    selectionChangedCommand = new DelegateCommand<EmailFolder>(OnEmailFolderChanged);
                }
                return selectionChangedCommand;
            }
        }

        public IEnumerable<EmailFolder> Folders
        {
            get { return emailService.MailFolders; }
        }

        private void OnEmailFolderChanged(EmailFolder newFolder)
        {
            EmailFolderChangeEvent evt = eventAggregator.GetEvent<EmailFolderChangeEvent>();
            evt.Publish(newFolder);
        }
    }
}