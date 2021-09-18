using System.Collections.Generic;

namespace MailSmgAPI.Models
{
    public enum MessageTypes
    {
        A, B, C
    }

    public class Message
    {
        public int MessageId { get; set; }
        public string MessageBody { get; set; }
        public MessageTypes MessageType { get; set; } 
        public int AccountId { get; set; }
        
        public ICollection<Account> Accounts { get; set; }
        public Post Post { get; set; }
        public Receiver Receiver { get; set; }
    }
}