using SahrotunShop.DataAccess.Utils;

namespace SahrotunShop.DataAccess.Common.Intefaces;

public interface IGetAll<TModel>
{
    public Task<IList<TModel>> GetAllAsync(PaginationParams @params);       
}
