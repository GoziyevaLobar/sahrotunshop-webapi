using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using SahrotunShop.Service.Interfaces.Auth;

namespace SahrotunShop.Service.Services.Auth;

public class IdentityService : IIdentityService
{
    private readonly IHttpContextAccessor _accessor;
    public IdentityService(IHttpContextAccessor accessor)
    {
        _accessor = accessor;
    }
    public long UserId
    {
        get;
        //{
        //    if (_accessor.HttpContext is null) return 0;
        //    var userId = _accessor.HttpContext.User.Claims.First(op => op.Type = "Id").Value;
        //    return long.Parse(userId);
        //}
    }

    public string FirstName => throw new NotImplementedException();

    public string LastName => throw new NotImplementedException();

    public string PhoneNumber => throw new NotImplementedException();

    public IdentityRole IdentityRole => throw new NotImplementedException();
}
