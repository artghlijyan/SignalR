namespace SignalR.Repo.Entities
{
    public class Message : BaseEntity
    {
        public string Text { get; set; }
        public string Title { get; set; }
        public int ConversationId { get; set; }
        public virtual Conversation Conversation { get; set; }
    }
}
