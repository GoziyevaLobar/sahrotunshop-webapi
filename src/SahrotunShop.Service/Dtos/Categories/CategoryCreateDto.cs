using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SahrotunShop.Service.Dtos.Categories;

public class CategoryCreateDto
{
    [Required(ErrorMessage = "Name is required")]
    [MaxLength(50, ErrorMessage = "Name must be less than 50 characters")]
    [MinLength(3, ErrorMessage = "Name must be more than 50 characters")]

    public string Name { get; set; } = String.Empty;

    public string Description { get; set; } = String.Empty;

    public IFormFile Image { get; set; } = default!;
}
