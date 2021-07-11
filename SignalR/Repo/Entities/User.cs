namespace SignalR.Repo.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ConversationId { get; set; }
        public Conversation Conversation { get; set; }
    }
}
