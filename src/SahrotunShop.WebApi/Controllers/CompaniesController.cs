﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SahrotunShop.DataAccess.Utils;
using SahrotunShop.Service.Dtos.Companies;
using SahrotunShop.Service.Interfaces.Companies;
using SahrotunShop.Service.Validators.Dtos.Companies;

namespace SahrotunShop.WebApi.Controllers;

[Route("api/companies")]
[ApiController]
public class CompaniesController : ControllerBase
{
    private readonly ICompanyService _service;
    private readonly int maxPageSize = 30;
    public CompaniesController(ICompanyService companyService)
    {
        this._service = companyService;
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> GetAllAsync([FromQuery] int page = 1)
        => Ok(await _service.GetAllAsync(new PaginationParams(page, maxPageSize)));

    [HttpGet("{companyId}")]
    [AllowAnonymous]
    public async Task<IActionResult> GetByIdAsync(long companyId)
        => Ok(await _service.GetByIdAsync(companyId));

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] CompanyCreateDto dto)
    {
        var validator = new CompanyCreateValidator();
        var result = validator.Validate(dto);
        if (result.IsValid) return Ok(await _service.CreateAsync(dto));
        else return BadRequest(result.Errors);
    }

    [HttpPut("{companyId}")]
    public async Task<IActionResult> UpdateAsync(long companyId, [FromForm] CompanyUpdateDto dto)
    {
        var validator = new CompanyUpdateValidator();
        var validationResult = validator.Validate(dto);
        if (validationResult.IsValid) return Ok(await _service.UpdateAsync(companyId, dto));
        else return BadRequest(validationResult.Errors);
    }

    [HttpDelete("{companyId}")]
    public async Task<IActionResult> DeleteAsync(long companyId)
        => Ok(await _service.DeleteAsync(companyId));
}