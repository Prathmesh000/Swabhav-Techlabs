using ContactAppRestApi2.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactAppRestApi2.Data
{
    public class ContactDbContext : DbContext
    {
        public string ConnectionString;
        public DbSet<User> Users {  get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }

        public ContactDbContext()
        {
            ConnectionString = "Data Source=DELL1564;Initial Catalog=contactapprestapirepo;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

    }
}
