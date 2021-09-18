using System.Collections.Generic;

namespace MailSmgAPI.Models
{
    public enum PaymentTypes
    {
        Credit, Cash, Check
    }
    
    public class Payment
    {
        public int PaymentId { get; set; }
        public int AccountId { get; set; }
        public string PaymentDate { get; set; }
        public PaymentTypes PaymentType { get; set; }
        public float PaymentCost { get; set; }
        public int PaymentPeriod { get; set; }
        
        public ICollection<Account> Accounts { get; set; }
    }
}