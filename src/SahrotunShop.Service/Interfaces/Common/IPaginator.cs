using SahrotunShop.DataAccess.Utils;

namespace SahrotunShop.Service.Interfaces.Common;

public interface IPaginator
{
    public void Paginate(long itemsCount, PaginationParams @params);
}
