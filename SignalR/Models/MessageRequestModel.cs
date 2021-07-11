using System;

namespace SignalR.Models
{
    public class MessageRequestModel
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
