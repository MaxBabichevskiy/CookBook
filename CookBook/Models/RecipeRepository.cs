using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Models
{
    public class RecipeRepository
    {
        private CookBookContext _context;

        public RecipeRepository()
        {
            
        }

        public RecipeRepository(CookBookContext context)
        {
            _context = context;
        }
        public async Task<List<Recipe>> GetRecipesAsync()
        {
            var recipes = new List<Recipe>
            {
                new Recipe { Name = "Рецепт 1", Cuisine = "Кухня 1", Type = "Тип 1"},
                new Recipe { Name = "Рецепт 2", Cuisine = "Кухня 2", Type = "Тип 2" },
                new Recipe { Name = "Рецепт 3", Cuisine = "Кухня 3", Type = "Тип 3" }
            };

            // Имитация асинхронной операции с использованием Task.Delay
            await Task.Delay(1000);

            return recipes;
        }
    }
}
