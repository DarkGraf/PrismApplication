using System;

namespace EmailEntities
{
    public class EmailFolderChangeEventArgs : EventArgs
    {
        public EmailFolderChangeType ChangeType { get; set; }
        public Email Email { get; set; }
    }
}