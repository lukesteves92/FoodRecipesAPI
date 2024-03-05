using RecipeApi.Infra.Data;
using RecipeApi.Interfaces;
using RecipeApi.Model;

namespace RecipeApi.Repository;

public class RecipeRepository: IRecipeRepository
{
    private readonly MockDatabase _database;
    public RecipeRepository(MockDatabase database)
        =>_database = database;

    public IEnumerable<Recipe> GetAll(string? search = null, int skip = 0, int take = 10, Guid? recipeGroupId = null)
    {
        IEnumerable<Recipe> query = _database.Recipes;
        
        //Filter by Search text
        if (!string.IsNullOrEmpty(search))
        {
            query = query
                //Search by Title
                .Where(e => e.Title.ToLower().Contains(search.ToLower())
                            // Search by ingredient name
                            || e.Ingredients.Any(x => x.Ingredient.Name.ToLower().Contains(search.ToLower())));
        } else if (recipeGroupId != null)
        {
            //Filter by Recipy Group Id
            query = query
                .Where(e => e.Group.Any(g => g.Id == recipeGroupId));
        }

        
        return query.Skip((skip -1) * take).Take(take).ToList();
    }

    public Recipe? GetById(Guid id)
        =>  _database.Recipes.FirstOrDefault(e=> e.Id == id);

    public IEnumerable<RecipeGroup> RecipeGroupGetAll()
        => _database.RecipeGroups.ToList();

    public IEnumerable<Country> CountryGetAll()
        => _database.Countries.ToList();
}