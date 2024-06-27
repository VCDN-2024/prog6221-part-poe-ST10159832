using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProgRecipeTester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // https://www.youtube.com/watch?v=ArnJ57ntgmc video used to create list, code was adapted 
        private List<Recipe> recipes = new List<Recipe>();


        public MainWindow()
        {
            InitializeComponent();
        }


        //https://www.youtube.com/watch?v=ArnJ57ntgmc video that was used to create logic 
        private void btnDspRecipeList_Click(object sender, RoutedEventArgs e)
        {
            if (recipes.Count == 0)
            {
                MessageBox.Show("No recipes available.", "Recipe List");
                return;
            }

            DisplayRecipeListForm displayRecipeListForm = new DisplayRecipeListForm(recipes);
            displayRecipeListForm.ShowDialog();
        }

        //https://www.youtube.com/watch?v=4nXUWpC2GuA&list=PL480DYS-b_kfOd8KRx93r92u5UYyzdQ_w&index=4 video that was used for logic 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RecipeDetailsForm fm1 = new RecipeDetailsForm();
            fm1.ShowDialog(); //https://stackoverflow.com/questions/3742709/this-visible-is-not-working-in-windows-forms website that was used to hide and show menu at times 

            if (!string.IsNullOrEmpty(fm1.RecipeName) && fm1.IngredientsList.Count > 0)
            {
                Recipe newRecipe = new Recipe(fm1.RecipeName)
                {
                    Ingredients = new List<Ingredient>(fm1.IngredientsList)
                };
                recipes.Add(newRecipe);
            }
        }

        private void btnSearchRecipe_Click(object sender, RoutedEventArgs e)
        {
            SearchforRecipeForm searchForm = new SearchforRecipeForm(recipes);
            searchForm.ShowDialog(); 
        }

        private void btnDspTotalCalories_Click(object sender, RoutedEventArgs e)
        {
            DisplayTotalCaloriesForm totalCaloriesForm = new DisplayTotalCaloriesForm(recipes);
            totalCaloriesForm.ShowDialog();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
// code attribution: Troelsen, A. and Japikse, P. (2022). Pro C# 10 with .NET 6. Apress.