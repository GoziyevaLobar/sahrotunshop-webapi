using SahrotunShop.DataAccess.Interfaces.Categories;
using SahrotunShop.DataAccess.Repositories.Categories;
using SahrotunShop.Service.Interfaces.Categories;
using SahrotunShop.Service.Interfaces.Common;
using SahrotunShop.Service.Services.Categories;
using SahrotunShop.Service.Services.Common;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//-->
builder.Services.AddScoped<ICategoryService, CategoryService>();  
builder.Services.AddScoped<  ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IFileService, FileService>();
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
