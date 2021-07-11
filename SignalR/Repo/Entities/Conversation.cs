using System.Collections.Generic;

namespace SignalR.Repo.Entities
{
    public class Conversation : BaseEntity
    {
        public Conversation()
        {
            Messages = new List<Message>();
            Users = new List<User>();
        }

        public string Name { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
