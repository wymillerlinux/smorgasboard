using System.Collections.Generic;

namespace MailSmgAPI.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public int MessageId { get; set; }
        public string PostBody { get; set; }
        public string PostAuthor { get; set; }
        public string PostMethodProtocol { get; set; }
        
        public ICollection<Message> Messages { get; set; }
    }
}