using SahrotunShop.DataAccess.Common.Intefaces;
using SahrotunShop.DataAccess.ViewModels.Users;
using SahrotunShop.Domain.Entities.Users;

namespace SahrotunShop.DataAccess.Interfaces.Users;

public interface IUserRepository :IRepository<User, UserViewModel>,
    IGetAll<UserViewModel>, ISearchable<UserViewModel>  
{
    public Task<User?> GetByPhoneAsync(string phone);
}
