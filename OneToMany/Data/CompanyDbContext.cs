using Microsoft.EntityFrameworkCore;
using OneToManyRestApi.Models;

namespace OneToManyRestApi.Data
{
    public class CompanyDbContext : DbContext
    {
        public string ConnectionString = "Data Source=DELL1564;Initial Catalog=OnetoManyRestApi;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;";
        public DbSet<Company> Companies { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }


    }
}
