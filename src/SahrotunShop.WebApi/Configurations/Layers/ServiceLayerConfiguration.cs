using SahrotunShop.Service.Interfaces.Auth;
using SahrotunShop.Service.Interfaces.Categories;
using SahrotunShop.Service.Interfaces.Common;
using SahrotunShop.Service.Interfaces.Companies;
using SahrotunShop.Service.Interfaces.Discounts;
using SahrotunShop.Service.Interfaces.Notifcations;
using SahrotunShop.Service.Services.Auth;
using SahrotunShop.Service.Services.Categories;
using SahrotunShop.Service.Services.Common;
using SahrotunShop.Service.Services.Companies;
using SahrotunShop.Service.Services.Discounts;
using SahrotunShop.Service.Services.Notifications;

namespace SahrotunShop.WebApi.Configurations.Layers;

public static class ServiceLayerConfiguration
{
    public static void ConfigureServiceLayer(this WebApplicationBuilder builder)
    {
        //--> DI containers, IoC containers
        builder.Services.AddScoped<IFileService, FileService>();
        builder.Services.AddScoped<ICategoryService, CategoryService>();
        builder.Services.AddScoped<ICompanyService, CompanyService>();
        builder.Services.AddScoped<IDiscountService, DiscountService>();
        builder.Services.AddScoped<IAuthService, AuthService>();
        builder.Services.AddScoped<ITokenService, TokenService>();
        builder.Services.AddScoped<IPaginator, Paginator>();
        builder.Services.AddSingleton<ISmsSender, SmsSender>();
        builder.Services.AddScoped<IIdentityService, IdentityService>();    
    }
}
