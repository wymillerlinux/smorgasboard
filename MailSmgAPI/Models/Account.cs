using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MailSmgAPI.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public string AccountUuid { get; set; }
        public string AccountName { get; set; }
        public string AccountEmail { get; set; }
        public string AccountWebsite { get; set; }

        public ICollection<Customer> Customers { get; set; }
        public Message Message { get; set; }
        public Payment Payment { get; set; }
    }
}