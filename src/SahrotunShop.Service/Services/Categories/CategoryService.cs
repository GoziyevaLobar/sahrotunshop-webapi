﻿using SahrotunShop.DataAccess.Interfaces.Categories;
using SahrotunShop.Domain.Entities.Categories;
using SahrotunShop.Domain.Exceptions.Categories;
using SahrotunShop.Domain.Exceptions.Files;
using SahrotunShop.Service.Common.Helpers;
using SahrotunShop.Service.Dtos.Categories;
using SahrotunShop.Service.Interfaces.Categories;
using SahrotunShop.Service.Interfaces.Common;

namespace SahrotunShop.Service.Services.Categories;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _repository;
    private readonly IFileService _fileService;

    public CategoryService(ICategoryRepository categoryRepository,
        IFileService fileService)
    {
        this._repository = categoryRepository;
        this._fileService = fileService;


    }

    public async Task<long> CountAsync() => await _repository.CountAsync();

    public async Task<bool> CreateAsync(CategoryCreateDto dto)
    {
        string imagepath = await _fileService.UploadImageAsync(dto.Image);
        Category category = new Category()
        {
            ImagePath = imagepath,
            Name = dto.Name,
            Description = dto.Description,
            CreatedAt = TimeHelper.GetDateTime(),
            UpdatedAt = TimeHelper.GetDateTime()
        };
        var result = await _repository.CreateAsync(category);
        return result>0;
    }

    public async Task<bool> DeleteAsync(long categoryId)
    {
        var category = await _repository.GetByIdAsync(categoryId);
        if (category is null) throw new CategoryNotFoundException();

        var result = await _fileService.DeleteImageAsync(category.ImagePath);
        if (result == false) throw new ImageNotFoundException();

        var dbResult = await _repository.DeleteAsync(categoryId);
        return dbResult > 0;
    }
}