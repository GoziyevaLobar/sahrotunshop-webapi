using SahrotunShop.Service.Common.Helpers;

namespace SahrotunShop.Service.Validators;

public class AllowFileExtensionValidator
{
    public static bool Validate(string extension)
    {
        return (MediaHelper.GetImageExtensions()).Contains(extension);  
    }
}
