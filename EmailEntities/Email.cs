using System;

namespace EmailEntities
{
    public class Email
    {
        public Email()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Sent { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public void Delete()
        {
            if (folder != null)
            {
                folder.DeleteMail(this);
            }
        }

        public void Enfolder(EmailFolder folder)
        {
            Delete();
            this.folder = folder;
            this.folder.AddMail(this);
        }

        public static Email Create()
        {
            Email email = new Email
            {
                To = "to@mailserver.com",
                From = "from@mailserver.com",
                Sent = DateTime.Now
            };

            email.Subject = string.Format("Email {0} Subject Line", email.Id);
            email.Body = string.Format("Email {0} Body Text", email.Id);
            return email;
        }

        EmailFolder folder;
    }
}