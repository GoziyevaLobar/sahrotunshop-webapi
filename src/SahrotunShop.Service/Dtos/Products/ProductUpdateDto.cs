using Microsoft.AspNetCore.Http;

namespace SahrotunShop.Service.Dtos.Products;

public class ProductUpdateDto
{
    public string Name { get; set; } = String.Empty;

    public string Description { get; set; } = String.Empty;
    public IFormFile? Image { get; set; }

    public double UnitPrice { get; set; }
}
