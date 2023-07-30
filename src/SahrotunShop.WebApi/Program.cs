using Microsoft.AspNetCore.Diagnostics;
using SahrotunShop.WebApi.Configurations;
using SahrotunShop.WebApi.Configurations.Layers;
using SahrotunShop.WebApi.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();
builder.Services.AddMemoryCache();
builder.ConfigurateJwtAuth();
builder.ConfigureSwaggerAuth();
builder.ConfigureCORSPolicy();
builder.ConfigureDataAcces();
builder.ConfigureServiceLayer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseStaticFiles();

app.UseMiddleware<ExceptionHandlerMiddlewares>();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
