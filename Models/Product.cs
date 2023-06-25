using System.ComponentModel.DataAnnotations.Schema;

namespace ef_core_101.Models;

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = default!;

    [Column(TypeName = "decimal(6, 2)")]
    public decimal Price { get; set; }


    public override string ToString() => $"{this.Name} is for only {string.Format(this.Price.ToString("C"))}!";
}