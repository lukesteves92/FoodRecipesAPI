using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RecipeApi.Model;

namespace RecipeApi.Interfaces;

public interface IRecipeRepository
{
    /// <summary>
    /// Get all recipes
    /// </summary>
    IEnumerable<Recipe> GetAll(string? search = null, int skip = 0, int take = 10, Guid? recipeGroupId = null);

    /// <summary>
    /// Get a recipe by unique identifier
    /// </summary>
    Recipe? GetById(Guid id);

    /// <summary>
    /// Get All Recipes Group
    /// </summary>
    IEnumerable<RecipeGroup> RecipeGroupGetAll();

    /// <summary>
    /// Get All Countries
    /// </summary>
    IEnumerable<Country> CountryGetAll();
}