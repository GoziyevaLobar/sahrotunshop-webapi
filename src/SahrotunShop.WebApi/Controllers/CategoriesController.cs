using Microsoft.AspNetCore.Mvc;
using SahrotunShop.DataAccess.Interfaces.Categories;
using SahrotunShop.DataAccess.Repositories.Categories;
using SahrotunShop.DataAccess.Utils;
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
    private readonly int maxPageSize = 30;

    public CategoriesController(ICategoryService service)
    {
        this._service = service;
    }
    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] int page = 1)
        =>Ok(await _service.GetAllAsync(new PaginationParams(page, maxPageSize)));

    [HttpGet("{categoryId}")]
    public async Task<IActionResult> GetByIdAsync(long categoryId)
            => Ok(await _service.GetByIdAsync(categoryId));

    [HttpGet("count")]
    public async Task<IActionResult> CountAsync()
        => Ok(await _service.CountAsync());


    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] CategoryCreateDto dto)
    =>Ok(await _service.CreateAsync(dto));

    [HttpPut("{categoryId}")]
    public async Task<IActionResult> UpdateAsync(long categoryId, [FromForm] CategoryUpdateDto dto) 
        => Ok(await _service.UpdateAsync(categoryId, dto)); 

    [HttpDelete("{categoryId}")]

    public async Task<IActionResult> DeleteAsync(long categoryId)
        => Ok(await _service.DeleteAsync(categoryId));
}
