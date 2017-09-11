using EmailEntities;
using EmailInterfaces;
using System.Collections.Generic;
using System.Threading;

namespace EmailService.Services
{
    public class EmailService : IEmailService
    {
        public EmailService()
        {
            CreateMailFolders();

            Timer timer = new Timer(o =>
            {
                Email email = Email.Create();
                email.Enfolder(MailFolders[0]);
            });

            timer.Change(0, 30000);
        }

        void CreateMailFolders()
        {
            MailFolders = new List<EmailFolder>
            {
                new EmailFolder(Email.Create())
                {
                    Name = "Inbox"
                },
                new EmailFolder()
                {
                    Name = "Sent Items"
                }
            };
        }

        public List<EmailFolder> MailFolders { get; private set; }

        public void DeleteMail(Email email)
        {
            email.Delete();
        }

        public void SendMail(Email email)
        {
            email.Enfolder(MailFolders[1]);
        }
    }
}