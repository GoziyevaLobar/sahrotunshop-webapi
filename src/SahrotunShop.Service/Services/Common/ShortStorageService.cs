namespace SahrotunShop.Service.Services.Common;

public class ShortStorageService : IShortStorageService
{
    private Dictionary<string, string> dict = new Dictionary<string, string>();     
    public IDictionary<string, string> KeyValuePairs { get; set; }

    public ShortStorageService()
    {
        KeyValuePairs = new Dictionary<string, string>();       
    }
}
