using SahrotunShop.DataAccess.Common.Intefaces;
using SahrotunShop.Domain.Entities.Categories;

namespace SahrotunShop.DataAccess.Interfaces.Categories;

public interface ICategoryRepository : IRepository<Category, Category>, IGetAll<Category>
{

}
