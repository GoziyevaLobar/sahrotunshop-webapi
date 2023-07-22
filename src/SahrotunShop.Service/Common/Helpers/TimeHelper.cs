using SahrotunShop.Domain.Constants;

namespace SahrotunShop.Service.Common.Helpers;

public class TimeHelper
{
    public static DateTime GetDateTime()
    {
        var dtTime = DateTime.UtcNow;
        dtTime.AddHours(TimeConstants.UTC);
        return dtTime;  
    }
}
