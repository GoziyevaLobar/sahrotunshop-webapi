using SahrotunShop.Service.Dtos.Notifcations;

namespace SahrotunShop.Service.Interfaces.Notifcations;

public interface ISmsSender
{
    public Task<bool> SendAsync(SmsMessage smsMessage);
}
