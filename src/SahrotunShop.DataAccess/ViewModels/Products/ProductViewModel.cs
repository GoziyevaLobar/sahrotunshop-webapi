using SahrotunShop.Domain.Entities;

namespace SahrotunShop.DataAccess.ViewModels.Products;  

public class ProductViewModel : Auditable
{
    public string Name { get; set; } = String.Empty;

    public string Description { get; set; } = String.Empty;

    public string ImagePath { get; set; } = String.Empty;

    public double UnitPrice { get; set; }

    public long CategoryId { get; set; }

    public long CompanyId { get; set; }
}
