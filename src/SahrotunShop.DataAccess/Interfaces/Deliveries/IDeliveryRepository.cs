using SahrotunShop.DataAccess.Interfaces;
using SahrotunShop.DataAccess.ViewModels.Deliveries;
using SahrotunShop.Domain.Entities.Deliveries;

namespace SahrotunShop.DataAccess.Common.Intefaces.Deliveries;

public interface IDeliveryRepository : IRepository<Deliver, Deliver>,
    IGetAll<DeliverViewModel>
{
    public Task<Deliver> GetDeliverAsync(long id);
}
