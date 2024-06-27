using System;
using System.Collections;
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
    public partial class AddRecipeForm : Form
    {
        private string recipeName;

        public static List<Ingredient> IngredientsList { get; private set; } = new List<Ingredient>(); //https://www.youtube.com/watch?v=ArnJ57ntgmc video and code was adapted slightly
        public AddRecipeForm(string recipeName)
        {
            InitializeComponent();
            this.recipeName = recipeName;
        }

        private void button1_Click(object sender, EventArgs e)
        { //https://www.youtube.com/watch?v=4nXUWpC2GuA&list=PL480DYS-b_kfOd8KRx93r92u5UYyzdQ_w&index=4 video that was used to get logic and syntax
            string IngredientName = txtbIngredientName.Text;
            double IngredientQuantity = Convert.ToDouble(txtbIngredientQuantity.Text);
            string UnitofMeasurement = txtbUnit.Text;
            int IngredientCalories = Convert.ToInt32(txtbCalories.Text);
            string FoodGroup = cbFoodGroup.Text;

            Ingredient ingredient = new Ingredient(IngredientName, IngredientQuantity, UnitofMeasurement, IngredientCalories, FoodGroup);
             ingredient.RecipeName = recipeName;
            



            // Clear input fields for next entry
            txtbIngredientName.Text = "";
            txtbIngredientQuantity.Text = "";
            txtbUnit.Text = "";
            txtbCalories.Text = "";
            cbFoodGroup.Text = "";

            IngredientsList.Add(ingredient);

            // Close the form after ingredient is added
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
