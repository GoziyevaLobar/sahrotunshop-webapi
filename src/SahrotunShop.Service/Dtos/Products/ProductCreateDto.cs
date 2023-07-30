using Microsoft.AspNetCore.Http;

namespace SahrotunShop.Service.Dtos.Products;

public class ProductCreateDto
{
    public string Name { get; set; } = String.Empty;

    public string Description { get; set; } = String.Empty;

    public IFormFile Image { get; set; } = default!;

    public double UnitPrice { get; set; }
}
