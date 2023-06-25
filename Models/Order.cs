namespace ef_core_101.Models;

public class Order
{
    public int Id { get; set; }

    public DateTime OrderPlaced { get; set; }

    public DateTime? OrderFulfilled { get; set; }

    // This is a navigation property which represents foreign key relationship (which joins this table) with the "Customer" table. 
    // This is called a "shadow property". We do not need to specify this because EF Core will automatically generate it.
    public int CustomerId { get; set; }

     public Customer Customer { get; set; } = default!;

    // Navigation property
    public ICollection<OrderDetail> OrderDetails { get; set; } = default!;
}