using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using SahrotunShop.DataAccess.Utils;
using SahrotunShop.Service.Dtos.Companies;
using SahrotunShop.Service.Dtos.Discounts;
using SahrotunShop.Service.Interfaces.Discounts;
using SahrotunShop.Service.Validators.Dtos.Companies;
using SahrotunShop.Service.Validators.Dtos.Discounts;

namespace SahrotunShop.WebApi.Controllers;

[Route("api/discounts")]
[ApiController]
public class DiscountsController : ControllerBase
{
    private readonly IDiscountService _service;
    private readonly int maxPageSize = 3;

    public DiscountsController(IDiscountService discountService)
    {
        this._service = discountService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] int page = 1)
        => Ok(await _service.GetAllAsync(new PaginationParams(page, maxPageSize)));

    [HttpGet("{discountId}")]
    public async Task<IActionResult> GetByIdAsync(long discountId)
        => Ok(await _service.GetByIdAsync(discountId));

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] DiscountCreateDto dto)
    {
        var validator = new DiscountCreateValidator();
        var result = validator.Validate(dto);
        if (result.IsValid) return Ok(await _service.CreateAsync(dto));
        else return BadRequest(result.Errors);
    }

    [HttpPut("{discountId}")]
    public async Task<IActionResult> UpdateAsync(long discountId, [FromForm] DiscountUpdateDto dto)
    {
        var validator = new DiscountUpdateValidator();
        var validationResult = validator.Validate(dto);
        if (validationResult.IsValid) return Ok(await _service.UpdateAsync(discountId, dto));
        else return BadRequest(validationResult.Errors);
    }

    [HttpDelete("{discountId}")]
    public async Task<IActionResult> DeleteAsync(long discountId)
        => Ok(await _service.DeleteAsync(discountId));
}
