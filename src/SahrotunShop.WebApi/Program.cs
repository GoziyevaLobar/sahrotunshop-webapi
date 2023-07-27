using SahrotunShop.DataAccess.Common.Intefaces.Discounts;
using SahrotunShop.DataAccess.Interfaces.Categories;
using SahrotunShop.DataAccess.Interfaces.Companies;
using SahrotunShop.DataAccess.Interfaces.Users;
using SahrotunShop.DataAccess.Repositories.Categories;
using SahrotunShop.DataAccess.Repositories.Companies;
using SahrotunShop.DataAccess.Repositories.Discounts;
using SahrotunShop.DataAccess.Repositories.Users;
using SahrotunShop.DataAccess.Utils;
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

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();
builder.Services.AddMemoryCache();

//--> DI containers, IoC containers
builder.Services.AddScoped<IFileService, FileService>();
builder.Services.AddScoped<ICategoryService, CategoryService>(); 
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IDiscountService, DiscountService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ITokenService, TokenService>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IDiscountRepository, DiscountRepository>();
builder.Services.AddScoped<IPaginator, Paginator>();

builder.Services.AddSingleton<ISmsSender, SmsSender>();
//-->


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles();   

app.UseAuthorization();

app.MapControllers();

app.Run();
