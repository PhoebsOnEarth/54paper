using System;
using SectionD.Models;
namespace SectionD.Services
{
    public class MessageTracker
    {
        public Dictionary<Guid,string> Messages { get; set; }
        public long Timestamp { get; set; }
        public MessageTracker()
        {
            Messages = new Dictionary<Guid, string>();
        }

        public void add(Message message)
        {
            Messages[message.Id] = message.Text;
        }

        public void Delete()
        {
            Messages.Remove(Messages.FirstOrDefault().Key);
        }
 
    }
}

