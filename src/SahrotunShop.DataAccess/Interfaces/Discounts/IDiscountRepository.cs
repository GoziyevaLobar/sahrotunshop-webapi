using SahrotunShop.DataAccess.Interfaces;
using SahrotunShop.DataAccess.Utils;
using SahrotunShop.Domain.Entities.Discounts;

namespace SahrotunShop.DataAccess.Common.Intefaces.Discounts;

public interface IDiscountRepository : IRepository<Discount, Discount>,
    IGetAll<Discount>
{
    public Task<IList<Discount>> GetAllByDurationAsync(DateTime startAt, DateTime endAt, PaginationParams @params);   
}

