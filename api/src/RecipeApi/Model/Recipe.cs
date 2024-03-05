using System;
using System.Collections.Generic;

namespace RecipeApi.Model;

public class Recipe
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string ImageBase64 { get; set; }
    public string Description { get; set; }
    public Country Country { get; set;}
    public ICollection<RecipeGroup> Group { get; private set; } = new List<RecipeGroup>();
    public ICollection<RecipeIngredient> Ingredients { get; private set; } = new List<RecipeIngredient>();
}