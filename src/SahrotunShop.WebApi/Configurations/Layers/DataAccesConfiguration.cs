using SahrotunShop.DataAccess.Common.Intefaces.Discounts;
using SahrotunShop.DataAccess.Interfaces.Categories;
using SahrotunShop.DataAccess.Interfaces.Companies;
using SahrotunShop.DataAccess.Interfaces.Users;
using SahrotunShop.DataAccess.Repositories.Categories;
using SahrotunShop.DataAccess.Repositories.Companies;
using SahrotunShop.DataAccess.Repositories.Discounts;
using SahrotunShop.DataAccess.Repositories.Users;

namespace SahrotunShop.WebApi.Configurations.Layers;

public static class DataAccesConfiguration
{
    public static void ConfigureDataAcces(this WebApplicationBuilder builder)
    {
        //--> DI containers, IoC containers
        builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
        builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
        builder.Services.AddScoped<IUserRepository, UserRepository>();
        builder.Services.AddScoped<IDiscountRepository, DiscountRepository>();
    } 
}
