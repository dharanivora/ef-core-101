namespace ef_core_101.Models;

public class OrderDetail
{
    public int Id { get; set; }

    public int Quantity { get; set; }

    // Navigation property. Represents fireign key relationship and is not strictly required.
    public int OrderId { get; set; }

    // Navigation property. Represents fireign key relationship and is not strictly required.
    public int ProductId { get; set; }

    public Order Order { get; set; } = default!;

    public Product Product { get; set; } = default!;
}