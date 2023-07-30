using SahrotunShop.DataAccess.Interfaces;
using SahrotunShop.DataAccess.ViewModels.Products;
using SahrotunShop.Domain.Entities.Products;

namespace SahrotunShop.DataAccess.Common.Intefaces.Products;

public interface IProductRepository : IRepository<Product, ProductViewModel>,
    IGetAll<ProductViewModel>, ISearchable<ProductViewModel>
{
}
