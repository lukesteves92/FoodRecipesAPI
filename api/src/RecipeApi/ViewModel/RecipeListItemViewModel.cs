using System;

namespace RecipeApi.ViewModel;

public class RecipeListItemViewModel
{
    public Guid Id { get;set; }
    public string Title { get; set; }
    public string ImageBase64 { get; set; }
}