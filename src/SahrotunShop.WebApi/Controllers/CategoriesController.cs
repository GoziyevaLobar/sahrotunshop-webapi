using Microsoft.AspNetCore.Mvc;
using SahrotunShop.DataAccess.Interfaces.Categories;
using SahrotunShop.DataAccess.Repositories.Categories;
using SahrotunShop.Domain.Entities.Categories;
using SahrotunShop.Service.Common.Helpers;
using SahrotunShop.Service.Dtos.Categories;
using SahrotunShop.Service.Interfaces.Categories;

namespace SahrotunShop.WebApi.Controllers;

[Route("api/categories")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _service;

    public CategoriesController(ICategoryService service)
    {
        this._service = service;
    }
    [HttpGet]

    public async Task<IActionResult> CountAsync()
        => Ok(await _service.CountAsync());

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] CategoryCreateDto dto)
    =>Ok(await _service.CreateAsync(dto));

    [HttpDelete]

    public async Task<IActionResult> DeleteAsync(long categoryId)
        => Ok(await _service.DeleteAsync(categoryId));
}
 