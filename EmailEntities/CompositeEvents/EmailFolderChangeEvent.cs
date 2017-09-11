using Prism.Events;

namespace EmailEntities.CompositeEvents
{
    public class EmailFolderChangeEvent : PubSubEvent<EmailFolder>
    {
    }
}