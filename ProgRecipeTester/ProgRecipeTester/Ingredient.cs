using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgRecipeTester
{
    public class Ingredient
    {
        public string RecipeName { get; set; }
        public string IngredientName {  get; set; }
      public double IngredientQuantity {  get; set; }
      public string UnitofMeasurement {  get; set; }
      public int IngredientCalories {  get; set; }
      public string FoodGroup {  get; set; }
       


        public Ingredient(string ingredientName, double ingredientQuantity, string unitofMeasurement, int ingredientCalories, string foodGroup) 
        {

            IngredientName = ingredientName;
            IngredientQuantity = ingredientQuantity;
            UnitofMeasurement = unitofMeasurement;
            FoodGroup = foodGroup;
            IngredientCalories = ingredientCalories;
            

        }

        public override string ToString()
        {
            return $" {IngredientQuantity} {UnitofMeasurement} of {IngredientName} contains {IngredientCalories} calories, Food group: {FoodGroup} ";
        }

    }
}
