namespace ef_core_101.Models;

public class Order
{
    public int Id { get; set; }

    public DateTime OrderPlaced { get; set; }

    public DateTime? OrderFulfilled { get; set; }

    public int CustomrId { get; set; }

    // This is called a "shadow property". We do not need to specify this because EF Core will automatically generate it.  
    // public Customer Customer { get; set; } = default!;

    public ICollection<OrderDetail> OrderDetails { get; set; } = default!;
}