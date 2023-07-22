using SahrotunShop.DataAccess.Utils;

namespace SahrotunShop.DataAccess.Common.Intefaces
{
    public interface ISearchable<TModel>
    {
        public Task<(int ItemsCount, IList<TModel>)> SearchAsync(string search,
            PaginationParams @params);
    }
}
