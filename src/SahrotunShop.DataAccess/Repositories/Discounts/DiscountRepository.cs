using SahrotunShop.DataAccess.Common.Intefaces.Discounts;
using SahrotunShop.DataAccess.Utils;
using SahrotunShop.Domain.Entities.Discounts;

namespace SahrotunShop.DataAccess.Repositories.Discounts;

public class DiscountRepository : IDiscountRepository
{
    public Task<long> CountAsync()
    {
        throw new NotImplementedException();
    }

    public Task<int> CreateAsync(Discount entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IList<Discount>> GetAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<IList<Discount>> GetAllByDurationAsync(DateTime startAt, DateTime endAt, PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<Discount?> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateAsync(long id, Discount entity)
    {
        throw new NotImplementedException();
    }
}
