using SahrotunShop.DataAccess.Utils;
using SahrotunShop.DataAccess.ViewModels.Products;
using SahrotunShop.Service.Dtos.Products;
using SahrotunShop.Service.Interfaces.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahrotunShop.Service.Services.Products
{
    public class ProductService : IProductService
    {
        public Task<bool> CreateAsync(ProductCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(long productId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<ProductViewModel>> GetAllAsync(PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public Task<ProductViewModel> GetByIdAsync(long productId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(long productId, ProductUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
