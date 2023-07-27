namespace SahrotunShop.Service.Dtos.Products;

public class ProductCreateDto
{
    public string Name { get; set; } = String.Empty;

    public string Description { get; set; } = String.Empty;

    public string ImagePath { get; set; } = String.Empty;

    public double UnitPrice { get; set; }
}
