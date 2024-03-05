using RecipeApi.Model;

namespace RecipeApi.Infra.Data;

public class MockDatabase
{
    #region :: Constructor
    
    public MockDatabase()
    {
        GenerateCountries();
        GenerateIngredients();
        GenerateRecipeGroups();
        GenerateRecipesSeed();
    }

    #endregion
    
    #region :: Collections
    public ICollection<Country> Countries { get; private set; } = new List<Country>();
    public ICollection<Ingredient> Ingredients { get; private set; } = new List<Ingredient>();
    public ICollection<RecipeGroup> RecipeGroups { get; private set; } = new List<RecipeGroup>();
    public ICollection<Recipe> Recipes { get; private set; } = new List<Recipe>();

    #endregion
    
    #region :: Countries
    
    private void GenerateCountries()
    {
        Countries.Add(new Country { Id = "bra", Name = "Brazil", GeoCoordinates = "-8.316872786362174|-55.72796170101549" }); 
        Countries.Add(new Country { Id = "deu", Name = "Germany", GeoCoordinates = "51.07047990058023|9.917896229113879"});
    }
    
    #endregion

    #region :: Ingredients
    
    private void GenerateIngredients()
    {
        Ingredients.Add(new Ingredient { Id = Guid.NewGuid(), Name = "Lime"});
        Ingredients.Add(new Ingredient { Id = Guid.NewGuid(), Name = "Sugar"});
        Ingredients.Add(new Ingredient { Id = Guid.NewGuid(), Name = "Cachaça"});
        Ingredients.Add(new Ingredient { Id = Guid.NewGuid(), Name = "Water"});
        Ingredients.Add(new Ingredient { Id = Guid.NewGuid(), Name = "Condensed Milk"});
        Ingredients.Add(new Ingredient { Id = Guid.NewGuid(), Name = "Ice"});
        
        Ingredients.Add(new Ingredient { Id = Guid.NewGuid(), Name = "Oil"});
        Ingredients.Add(new Ingredient { Id = Guid.NewGuid(), Name = "Eggs"});
        Ingredients.Add(new Ingredient { Id = Guid.NewGuid(), Name = "Vanilla"});
        Ingredients.Add(new Ingredient { Id = Guid.NewGuid(), Name = "Cinnamon"});
        Ingredients.Add(new Ingredient { Id = Guid.NewGuid(), Name = "Soda"});
        Ingredients.Add(new Ingredient { Id = Guid.NewGuid(), Name = "Salt"});
        Ingredients.Add(new Ingredient { Id = Guid.NewGuid(), Name = "Apples"});
    }
    
    #endregion
    
    #region :: RecipeGroups
    private void GenerateRecipeGroups()
    {
        RecipeGroups.Add(new RecipeGroup{Id = Guid.NewGuid(), Name = "Drinks"});
        RecipeGroups.Add(new RecipeGroup{Id = Guid.NewGuid(), Name = "Cakes"});
    }
    #endregion
    
    #region :: Recipes
    private void GenerateRecipesSeed()
    {
        Recipe? recipe = null;
        Recipe? recipe2 = null;
        Recipe? recipe3 = null;
        
        #region => Recipe 01
        
        //Recipe
        recipe = new Recipe
        {
            Id = Guid.NewGuid(), 
            Title = "Brazilian Caipirinha",
            Country = Countries.First(e => e.Id == "bra"),
            ImageBase64 = MockImages.ImageRecipe1,
            Description = @"Mojito fans in particular will love this light, zesty yet punchy cocktail from Brazil. It's made with just three ingredients - cachaça, lime and sugar"
        };
        //Groups
        recipe.Group.Add(RecipeGroups.First(e => e.Name == "Drinks"));
        
        //Ingredients
        recipe.Ingredients.Add(new RecipeIngredient
        {
            Id   = Guid.NewGuid(),
            Quantity = 1.5,
            Ingredient = Ingredients.First(e=> e.Name == "Lime")
        });
        recipe.Ingredients.Add(new RecipeIngredient
        {
            Id   = Guid.NewGuid(),
            Quantity = 2,
            Ingredient = Ingredients.First(e=> e.Name == "Sugar")
        });
        recipe.Ingredients.Add(new RecipeIngredient
        {
            Id   = Guid.NewGuid(),
            Quantity = 1,
            Ingredient = Ingredients.First(e=> e.Name == "Cachaça")
        });
        
        //Add
        Recipes.Add(recipe);
        
        #endregion
        
        #region => Recipe 02
        
        //Recipe
        recipe2 = new Recipe
        {
            Id = Guid.NewGuid(), 
            Title = "German Apple Cake",
            Country = Countries.First(e => e.Id == "deu"),
            ImageBase64 = MockImages.ImageRecipe2,
            Description = @"German apple cake is a moist, dense cake that keeps well. It has been a family favorite for 20 years. Serve with a dusting of confectioners' sugar or topped with a cream cheese frosting."
        };
        //Groups
        recipe2.Group.Add(RecipeGroups.First(e => e.Name == "Cakes"));
        
        //Ingredients
        recipe2.Ingredients.Add(new RecipeIngredient
        {
            Id   = Guid.NewGuid(),
            Quantity = 1,
            Ingredient = Ingredients.First(e=> e.Name == "Oil")
        });
        recipe2.Ingredients.Add(new RecipeIngredient
        {
            Id   = Guid.NewGuid(),
            Quantity = 1,
            Ingredient = Ingredients.First(e=> e.Name == "Sugar")
        });
        recipe2.Ingredients.Add(new RecipeIngredient
        {
            Id   = Guid.NewGuid(),
            Quantity = 1,
            Ingredient = Ingredients.First(e=> e.Name == "Eggs")
        });
        recipe2.Ingredients.Add(new RecipeIngredient
        {
            Id   = Guid.NewGuid(),
            Quantity = 1,
            Ingredient = Ingredients.First(e=> e.Name == "Vanilla")
        });
        recipe2.Ingredients.Add(new RecipeIngredient
        {
            Id   = Guid.NewGuid(),
            Quantity = 1,
            Ingredient = Ingredients.First(e=> e.Name == "Cinnamon")
        });
        recipe2.Ingredients.Add(new RecipeIngredient
        {
            Id   = Guid.NewGuid(),
            Quantity = 1,
            Ingredient = Ingredients.First(e=> e.Name == "Soda")
        });
        recipe2.Ingredients.Add(new RecipeIngredient
        {
            Id   = Guid.NewGuid(),
            Quantity = 1,
            Ingredient = Ingredients.First(e=> e.Name == "Salt")
        });
        recipe2.Ingredients.Add(new RecipeIngredient
        {
            Id   = Guid.NewGuid(),
            Quantity = 1,
            Ingredient = Ingredients.First(e=> e.Name == "Apples")
        });
        
        //Add
        Recipes.Add(recipe2);
        
        #endregion
        
        #region => Recipe 03
        
        //Recipe
        recipe3 = new Recipe
        {
            Id = Guid.NewGuid(), 
            Title = "Brazilian Lemonade",
            Country = Countries.First(e => e.Id == "bra"),
            ImageBase64 = MockImages.ImageRecipe3,
            Description = @"This Brazilian lemonade recipe actually uses limes! It is best served immediately."
        };
        //Groups
        recipe3.Group.Add(RecipeGroups.First(e => e.Name == "Drinks"));
        
        //Ingredients
        recipe3.Ingredients.Add(new RecipeIngredient
        {
            Id   = Guid.NewGuid(),
            Quantity = 1,
            Ingredient = Ingredients.First(e=> e.Name == "Lime")
        });
        recipe3.Ingredients.Add(new RecipeIngredient
        {
            Id   = Guid.NewGuid(),
            Quantity = 1,
            Ingredient = Ingredients.First(e=> e.Name == "Sugar")
        });
        recipe3.Ingredients.Add(new RecipeIngredient
        {
            Id   = Guid.NewGuid(),
            Quantity = 1,
            Ingredient = Ingredients.First(e=> e.Name == "Water")
        });
        recipe3.Ingredients.Add(new RecipeIngredient
        {
            Id   = Guid.NewGuid(),
            Quantity = 1,
            Ingredient = Ingredients.First(e=> e.Name == "Condensed Milk")
        });
        recipe3.Ingredients.Add(new RecipeIngredient
        {
            Id   = Guid.NewGuid(),
            Quantity = 1,
            Ingredient = Ingredients.First(e=> e.Name == "Ice")
        });
        
        //Add
        Recipes.Add(recipe3);
        
        #endregion
    }
    
    #endregion
    
}