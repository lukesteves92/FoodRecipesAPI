using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RecipeApi.Infra.Data;
using RecipeApi.Interfaces;
using RecipeApi.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<MockDatabase>();
builder.Services.AddTransient<IRecipeRepository, RecipeRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var recipeRepository = app.Services.GetService<IRecipeRepository>();

#region :: Actions

app.MapGet("/recipe", (string? search = null, int skip = 0, int take = 10, Guid? recipeGroupId = null) =>
    recipeRepository.GetAll(search, skip, take, recipeGroupId))
    .WithName("GetAll")
    .WithOpenApi();

app.MapGet("/recipe/{id}", (Guid id) => 
        recipeRepository.GetById(id))
    .WithName("GetById")
    .WithOpenApi();

app.MapGet("/recipe/Group", () => 
        recipeRepository.RecipeGroupGetAll())
    .WithName("RecipeGroupsGetAll")
    .WithOpenApi();

app.MapGet("/country", () => 
        recipeRepository.CountryGetAll())
    .WithName("CountryGetAll")
    .WithOpenApi();

#endregion

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}