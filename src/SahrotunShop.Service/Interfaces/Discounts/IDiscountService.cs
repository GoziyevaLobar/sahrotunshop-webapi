using SahrotunShop.DataAccess.Utils;
using SahrotunShop.Domain.Entities.Companies;
using SahrotunShop.Domain.Entities.Discounts;
using SahrotunShop.Service.Dtos.Companies;
using SahrotunShop.Service.Dtos.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahrotunShop.Service.Interfaces.Discounts
{
    public interface IDiscountService
    {
        public Task<bool> CreateAsync(DiscountCreateDto dto);

        public Task<IList<Discount>> GetAllAsync(PaginationParams @params);

        public Task<Discount> GetByIdAsync(long discountId);

        public Task<bool> UpdateAsync(long discountId, DiscountUpdateDto dto);

        public Task<bool> DeleteAsync(long discountId);
    }
}
