using System;

namespace RecipeApi.Model;

public class RecipeIngredient
{
    public Guid Id { get; set; }
    public Guid RecipeId { get; set; }
    public double Quantity { get; set; }
    public string Unit { get; set; }
    public Ingredient Ingredient { get; set; } = new Ingredient();
}