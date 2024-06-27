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
    public partial class DisplayTotalCaloriesForm : Form
    {
        private List<Recipe> recipes; //https://www.youtube.com/watch?v=ArnJ57ntgmc video used for logic 

        public DisplayTotalCaloriesForm(List<Recipe> recipes)
        {
            InitializeComponent(); 
            this.recipes = recipes;
        }

        private void btnSubmitTotalCalories_Click(object sender, EventArgs e) //https://www.youtube.com/watch?v=4nXUWpC2GuA&list=PL480DYS-b_kfOd8KRx93r92u5UYyzdQ_w&index=5
        {
            string recipeName = txtbRecipeNameInput.Text.Trim();
            Recipe selectedRecipe = recipes.FirstOrDefault(r => r.RecipeName.Equals(recipeName, StringComparison.OrdinalIgnoreCase));

            if (selectedRecipe != null)
            {
                int totalCalories = CalculateTotalCalories(selectedRecipe.IngredientsList);
                string message = $"Total calories in {selectedRecipe.RecipeName}: {totalCalories}\n";

                if (totalCalories > 300)
                {
                    message += "Warning: Calories exceed 300!";
                }

                MessageBox.Show(message, "Total Calories", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Recipe not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CalculateTotalCalories(List<Ingredient> ingredients) 
        {
            int totalCalories = 0;  // website used for logic plus previous project https://www.simplilearn.com/tutorials/asp-dot-net-tutorial/csharp-foreach#:~:text=In%20C%23%2C%20for%20example%2C%20you,a%20List%20collection.&text=In%20this%20example%2C%20we%20have,loop%2C%20we%20use%20the%20Console.
            foreach (Ingredient ingredient in ingredients) // for each loop that will iterate through the array and find calories value 
            {
                totalCalories += ingredient.IngredientCalories;
            }
            return totalCalories;
        }

        private void txtbRecipeNameInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
