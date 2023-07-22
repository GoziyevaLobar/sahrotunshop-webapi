using System.Runtime.CompilerServices;

namespace SahrotunShop.Domain.Exceptions.Users;

public class UserNotFoundException : NotFoundException
{
    public UserNotFoundException()
    {
        this.TitleMessage = "User not found";
    }
}
