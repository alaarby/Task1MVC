using Microsoft.EntityFrameworkCore;
using Task1MVC.Models;

namespace Task1MVC.Data

{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=.; Database=Task1MVC; TrustServerCertificate=True; Trusted_Connection=True");
        }
    }
}
