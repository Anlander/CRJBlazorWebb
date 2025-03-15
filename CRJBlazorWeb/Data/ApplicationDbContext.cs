using CRJBlazorWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CRJBlazorWeb.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Product 1", Price = 100, Image = "https://i.imgur.com/QkIa5tT.jpeg", Description = "This is product 1" },
            new Product { Id = 2, Name = "Product 2", Price = 100, Image = "https://i.imgur.com/QkIa5tT.jpeg", Description = "This is product 2" },
            new Product { Id = 3, Name = "Product 3", Price = 100, Image = "https://i.imgur.com/QkIa5tT.jpeg", Description = "This is product 3" },
            new Product { Id = 4, Name = "Uniq product 1337", Price = 100, Image = "https://i.imgur.com/QkIa5tT.jpeg", Description = "This is christers product!" }
        );
    }
}
