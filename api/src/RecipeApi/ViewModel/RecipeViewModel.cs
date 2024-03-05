using System;
using System.Collections.Generic;

namespace RecipeApi.ViewModel;

public class RecipeViewModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string ImageBase64 { get; set; }
    public string Description { get; set; }
    public string CountryId { get; set; }
    public string CountryName { get; set; }
    public string CountryGeoCoordinates { get; set; }
    public IEnumerable<RecipeIngredientsViewModel> Ingredients { get; set; }
}