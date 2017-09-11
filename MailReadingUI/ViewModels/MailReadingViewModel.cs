using EmailEntities;
using EmailEntities.CompositeEvents;
using PresentationUtility.PropertyChanged;
using Prism.Events;

namespace MailReadingUI.ViewModels
{
    public class MailReadingViewModel : PropertyChangedImplementation
    {
        Email currentEmail;

        public MailReadingViewModel(IEventAggregator eventAggregator)
        {
            EmailSelectionChangedEvent evt = eventAggregator.GetEvent<EmailSelectionChangedEvent>();
            evt.Subscribe(OnSelectedEmailChanged);
        }

        private void OnSelectedEmailChanged(Email selectedEmail)
        {
            currentEmail = selectedEmail;
            FirePropertyChanged("Body");
        }

        public string Body
        {
            get
            {
                return currentEmail == null ? string.Empty : currentEmail.Body;
            }
        }
    }
}