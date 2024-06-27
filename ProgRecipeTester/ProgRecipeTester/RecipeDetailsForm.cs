using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ProgRecipeTester
{
    public partial class RecipeDetailsForm : Form
    { //https://www.youtube.com/watch?v=ArnJ57ntgmc most of the logic was taken from this video and changed to work on this project
        public string RecipeName { get; private set; }
        public int NumofIngredients { get; private set; }
        public List<Ingredient> IngredientsList { get; private set; } = new List<Ingredient>();

        public List<StepsClass> StepsList { get; private set; } = new List<StepsClass>();
        public RecipeDetailsForm()
        {
            InitializeComponent();
        }

     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecipeName = textBox1.Text;
            NumofIngredients = (int)numericUpDown1.Value;

            for (int i = 0; i < NumofIngredients; i++) //https://www.mooict.com/wpf-c-tutorial-running-a-for-each-loop-for-controls-in-visual-studio/ - website was used to create a loop for iterating
            {
                AddRecipeForm addRecipeForm = new AddRecipeForm(RecipeName); 
                addRecipeForm.ShowDialog();

                IngredientsList.AddRange(AddRecipeForm.IngredientsList);

            }

            nudSteps nsf = new nudSteps();
            this.Hide();
            nsf.ShowDialog();

            StepsList.AddRange(nsf.GetSteps());
        }
    }
}
