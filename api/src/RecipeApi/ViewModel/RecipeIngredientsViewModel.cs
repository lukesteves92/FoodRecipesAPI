using System;

namespace RecipeApi.ViewModel;

public class RecipeIngredientsViewModel
{
    public Guid Id { get; set; }
    public Guid RecipeId { get; set; }
    public double Quantity { get; set; }
    public string Unit { get; set; }
    public Guid IngredientId { get; set; }
    public string IngredientName { get; set; }
}