namespace SahrotunShop.Domain.Entities.Suppliers;

public class Supplier : Auditable
{
    public long ProductId { get; set; }

    public long SupplierId { get; set; }

    public int Quantity { get; set; }

    public double UnitPrice { get; set; }

    public string Description { get; set; } = String.Empty;
}
