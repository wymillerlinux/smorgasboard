using Microsoft.EntityFrameworkCore;

namespace MailSmgAPI.Models
{
    public class MailContext : DbContext
    {
        public MailContext(DbContextOptions<MailContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Receiver> Receiver { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Payment> Payment { get; set; }
    }
}