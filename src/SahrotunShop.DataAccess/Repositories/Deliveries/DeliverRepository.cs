using SahrotunShop.DataAccess.Common.Intefaces.Deliveries;
using SahrotunShop.DataAccess.Utils;
using SahrotunShop.DataAccess.ViewModels.Deliveries;
using SahrotunShop.Domain.Entities.Deliveries;

namespace SahrotunShop.DataAccess.Repositories.Deliveries;

public class DeliverRepository : IDeliveryRepository
{
    public Task<long> CountAsync()
    {
        throw new NotImplementedException();
    }

    public Task<int> CreateAsync(Deliver entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IList<DeliverViewModel>> GetAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<Deliver?> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Deliver> GetDeliverAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateAsync(long id, Deliver entity)
    {
        throw new NotImplementedException();
    }
}
