using EmailEntities;
using EmailEntities.CompositeEvents;
using EmailInterfaces;
using PresentationUtility.PropertyChanged;
using Prism.Commands;
using Prism.Events;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using System;

namespace MailListUI.ViewModels
{
    public class MailListViewModel : PropertyChangedImplementation
    {
        IEventAggregator eventAggregator;
        IDispatcherService dispatcherService;
        IEmailService emailService;
        EmailFolder currentFolder;
        ObservableCollection<MailViewModel> emails;

        ICommand selectionChangedCommand;

        public MailListViewModel(IEventAggregator eventAggregator, IDispatcherService dispatcherService,
            IEmailService emailService)
        {
            this.eventAggregator = eventAggregator;
            this.dispatcherService = dispatcherService;
            this.emailService = emailService;

            EmailFolderChangeEvent evt = eventAggregator.GetEvent<EmailFolderChangeEvent>();
            evt.Subscribe(OnEmailFolderChanged);
        }

        public void OnEmailFolderChanged(EmailFolder newFolder)
        {
            if (currentFolder != null)
            {
                currentFolder.EmailChanged -= OnFolderContentsChanged;
            }

            currentFolder = newFolder;
            currentFolder.EmailChanged += OnFolderContentsChanged;

            ObservableCollection<MailViewModel> newEmails = new ObservableCollection<MailViewModel>();
            foreach (Email email in currentFolder.Emails)
            {
                newEmails.Add(new MailViewModel(email, emailService));
            }
            Emails = newEmails;
        }

        public ICommand SelectionChangedCommand
        {
            get
            {
                if (selectionChangedCommand == null)
                {
                    selectionChangedCommand = new DelegateCommand<MailViewModel>(OnEmailSelectionChanged);
                }
                return selectionChangedCommand;
            }
        }

        public void OnEmailSelectionChanged(MailViewModel viewModel)
        {
            EmailSelectionChangedEvent evt = eventAggregator.GetEvent<EmailSelectionChangedEvent>();
            evt.Publish(viewModel == null ? null : viewModel.Email);
        }

        void OnFolderContentsChanged(object sender, EmailFolderChangeEventArgs args)
        {
            if (args.ChangeType == EmailFolderChangeType.Added)
            {
                dispatcherService.Dispatch(() =>
                {
                    Emails.Add(new MailViewModel(args.Email, emailService));
                });
            }
            else
            {
                dispatcherService.Dispatch(() =>
                {
                    Emails.Remove(Emails.Where(e => e.Email.Id == args.Email.Id).Single());
                });
            }
        }

        public ObservableCollection<MailViewModel> Emails
        {
            get { return emails; }
            set
            {
                emails = value;
                FirePropertyChanged("Emails");
            }
        }
    }
}