namespace MailSmgAPI.Models
{
    public class Receiver
    {
        public int ReceiverId { get; set; }
        public int MessageId { get; set; }
        public string ReceiverFirstName { get; set; }
        public string ReceiverLastName { get; set; }
        public string ReceiverEmail { get; set; }
        
        public Message Message { get; set; }
    }
}