using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.EntityFramework.DB;

public class AppEfContext : DbContext
{
    public AppEfContext(DbContextOptions<AppEfContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    
    public DbSet<Client> Clients { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public DbSet<ProductCategory> ProductCategory { get; set; }
}