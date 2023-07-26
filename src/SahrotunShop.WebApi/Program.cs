using SahrotunShop.DataAccess.Interfaces.Categories;
using SahrotunShop.DataAccess.Interfaces.Companies;
using SahrotunShop.DataAccess.Repositories.Categories;
using SahrotunShop.DataAccess.Repositories.Companies;
using SahrotunShop.DataAccess.Utils;
using SahrotunShop.Service.Interfaces.Categories;
using SahrotunShop.Service.Interfaces.Common;
using SahrotunShop.Service.Interfaces.Companies;
using SahrotunShop.Service.Services.Categories;
using SahrotunShop.Service.Services.Common;
using SahrotunShop.Service.Services.Companies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddHttpContextAccessor();
builder.Services.AddSwaggerGen();

//--> DI containers, IoC containers
builder.Services.AddScoped<IFileService, FileService>();
builder.Services.AddScoped<ICategoryService, CategoryService>(); 
builder.Services.AddScoped<ICompanyService, CompanyService>();  
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<IPaginator, Paginator>();
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
