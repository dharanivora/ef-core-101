using ef_core_101.Models;
using Microsoft.EntityFrameworkCore;

namespace ef_core_101.Data;

public class ContosoPizzaContext : DbContext
{
    public ContosoPizzaContext(DbContextOptions<ContosoPizzaContext> options) : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; } = default!;

    public DbSet<Order> Orders { get; set; } = default!;

    public DbSet<OrderDetail> OrderDetails { get; set; } = default!;

    public DbSet<Product> Products { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Database=ef-core-101;User Id=sa;Password=&hq9%8Tb6X;TrustServerCertificate=true");
    }
}