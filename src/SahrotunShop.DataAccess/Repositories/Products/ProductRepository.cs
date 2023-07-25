using SahrotunShop.DataAccess.Common.Intefaces.Products;
using SahrotunShop.DataAccess.Utils;
using SahrotunShop.DataAccess.ViewModels.Products;
using SahrotunShop.Domain.Entities.Products;

namespace SahrotunShop.DataAccess.Repositories.Products;

public class ProductRepository : IProductRepository
{
    public Task<long> CountAsync()
    {
        throw new NotImplementedException();
    }

    public Task<int> CreateAsync(Product entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IList<ProductViewModel>> GetAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<ProductViewModel?> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<(int ItemsCount, IList<ProductViewModel>)> SearchAsync(string search, PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateAsync(long id, Product entity)
    {
        throw new NotImplementedException();
    }
}
