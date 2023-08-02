using Microsoft.EntityFrameworkCore;
using TestApp.Data.Models;

namespace TestApp.Data;

public class AppDbContext : DbContext
{

    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }


    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public AppDbContext()
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TestData;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasKey(p => p.Id);

        modelBuilder.Entity<User>()
            .HasKey(u => u.Id);

        base.OnModelCreating(modelBuilder);
    }
}