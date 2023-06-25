namespace ef_core_101.Models;

public class Customer
{
    // [Key] attribute is used to indicate that this is the primary key of this table. If the property name does not contain "Id" word, then [Key] attribute must be specified.
    public int Id { get; set; }

    // "!" is to tell the compiler not to give us the warning about this property's value being null. This is a non-nullable value.
    public string FirstName { get; set; } = default!;

    public string LastName { get; set; } = default!;

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public ICollection<Order> Orders { get; set; } = default!;
}