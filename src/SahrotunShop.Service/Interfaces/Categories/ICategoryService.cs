using SahrotunShop.DataAccess.Utils;
using SahrotunShop.Domain.Entities.Categories;
using SahrotunShop.Service.Dtos.Categories;

namespace SahrotunShop.Service.Interfaces.Categories;

public interface ICategoryService
{
    public Task<bool> CreateAsync(CategoryCreateDto dto);

    public Task<bool> DeleteAsync(long categoryId);

    public Task<long> CountAsync();

    public Task<IList<Category>> GetAllAsync(PaginationParams @params);

    public Task<Category> GetByIdAsync(long categoryId);

    public Task<bool> UpdateAsync(long categoryId, CategoryUpdateDto dto);
}
