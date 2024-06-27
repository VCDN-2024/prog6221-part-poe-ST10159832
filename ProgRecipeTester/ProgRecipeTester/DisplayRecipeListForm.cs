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
    public partial class DisplayRecipeListForm : Form
    {

        private List<Recipe> _recipes;

        public DisplayRecipeListForm(List<Recipe> recipes)
        {
            InitializeComponent();
            _recipes = recipes;
            DisplayRecipes(_recipes);
        }
        //https://www.youtube.com/watch?v=ArnJ57ntgmc
        private void DisplayRecipes(List<Recipe> recipes)
        {
            var sortedRecipes = recipes.OrderBy(r => r.RecipeName).ToList(); //this methods will sort out the recipes in alphabetical order and display it on the list view 
            lstbDisplayRecipe.Items.Clear();
            foreach (var recipe in sortedRecipes)
            {
                lstbDisplayRecipe.Items.Add(recipe.RecipeName);
            }
        }

        private void txtbSearchforRecipe_TextChanged(object sender, EventArgs e)//textbox for users to enter which recipe they want to view from the list box
        {
            string searchText = txtbSearchforRecipe.Text.ToLower();
            var filteredRecipes = _recipes.Where(r => r.RecipeName.ToLower().Contains(searchText)).ToList();
            DisplayRecipes(filteredRecipes);
        }

        private void lstbDisplayRecipe_SelectedIndexChanged(object sender, EventArgs e)//listbox that is going to show the recipes in alphabetical order 
        {
            
        }

        private void btnDisplayRecipe_Click(object sender, EventArgs e) //button to display the recipe the user has entered in the txtbSearchforRecipe
        {
            string searchText = txtbSearchforRecipe.Text.ToLower();
            Recipe selectedRecipe = _recipes.FirstOrDefault(r => r.RecipeName.ToLower().Contains(searchText));
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
