using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgRecipeTester
{
    public partial class SearchforRecipeForm : Form
    {
        private List<Recipe> recipes;

        public SearchforRecipeForm(List<Recipe> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;
        }

        private void txtbSearchRecipeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //https://www.youtube.com/watch?v=S53DYhsxkBo video used for searching an array for a value
        {
            string searchText = txtbSearchRecipeName.Text.ToLower(); // this method basically goes through the array and find the recipe name and displays it 
            Recipe selectedRecipe = recipes.FirstOrDefault(r => r.RecipeName.ToLower().Contains(searchText)); // this sets the recipe name to all lower caps so it finds accurate search results 
            if (selectedRecipe != null)
            {
                StringBuilder recipeDetails = new StringBuilder();
                recipeDetails.AppendLine($"Recipe: {selectedRecipe.RecipeName}");
                recipeDetails.AppendLine("Ingredients:"); 
                foreach (var ingredient in selectedRecipe.Ingredients)
                {
                    recipeDetails.AppendLine($"- {ingredient.IngredientQuantity} {ingredient.UnitofMeasurement} of {ingredient.IngredientName} ({ingredient.FoodGroup}, {ingredient.IngredientCalories} calories)");
                }
                recipeDetails.AppendLine("Steps:");
                foreach (var step in selectedRecipe.Steps)
                {
                    recipeDetails.AppendLine($"- {step.Steps}");
                }

                MessageBox.Show(recipeDetails.ToString(), "Recipe Details");
            }
            else
            {
                MessageBox.Show("Recipe not found.", "Error");
            }
        }
        
    }
}
