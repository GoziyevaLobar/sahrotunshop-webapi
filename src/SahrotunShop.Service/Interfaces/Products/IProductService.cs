using SahrotunShop.DataAccess.Utils;
using SahrotunShop.DataAccess.ViewModels.Products;
using SahrotunShop.Domain.Entities.Discounts;
using SahrotunShop.Domain.Entities.Products;
using SahrotunShop.Service.Dtos.Discounts;
using SahrotunShop.Service.Dtos.Products;

namespace SahrotunShop.Service.Interfaces.Products;

public interface IProductService
{
    public Task<bool> CreateAsync(ProductCreateDto dto);

    public Task<IList<ProductViewModel>> GetAllAsync(PaginationParams @params);

    public Task<ProductViewModel> GetByIdAsync(long productId);

    public Task<bool> UpdateAsync(long productId, ProductUpdateDto dto);

    public Task<bool> DeleteAsync(long productId);
}
