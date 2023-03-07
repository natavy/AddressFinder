using AddressFinder.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;

namespace AddressFinder.Data
{
    public class AddressFinderDbContext:DbContext
    {
       
        public DbSet<Address>? Addresses { get; set; }
        protected override void OnConfiguring(
             DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=NATASHA-PC\\SQLEXPRESS;Database=AF_DB;Trusted_Connection=True;TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}