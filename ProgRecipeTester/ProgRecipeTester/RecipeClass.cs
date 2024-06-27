using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgRecipeTester
{
    public class Recipe
    {
        public string RecipeName { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public List<StepsClass> Steps { get; set; } = new List<StepsClass>();

        public List<Ingredient> IngredientsList { get; set; }

        public Recipe(string recipeName)
        {
            RecipeName = recipeName;
            Ingredients = new List<Ingredient>();
            Steps = new List<StepsClass>();
        }
    }
}
