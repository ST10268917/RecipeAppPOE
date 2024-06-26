using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    public class Recipe
    {
        //____________________ CODE ATTRIBUTION _______________________________________
        //The following layout  of using automatic properties (shorthand) was taken from W3 Schools 
        // Link: https://www.w3schools.com/cs/cs_properties.php (Accessed 15 April 2024)
        public string Name { get; set; }
        public int Num_ingredients { get; set; }
        public int Num_steps { get; set; }
        public double ScaleFactor { get; set; }
        public double? totalCalories { get; set; }


        //____________________ CODE ATTRIBUTION _______________________________________
        //The following layout of how to use Lists in C# was taken from GeeksForGeeks 
        // Link: https://www.geeksforgeeks.org/c-sharp-list-class/ (Accessed 12 May 2024)
        public List<string> Ingredients = new List<string>();
        public List<double> IngredientQuantities = new List<double>();
        public List<double> IngredientQuantitiesScaled = new List<double>();
        public List<string> IngredientUnitsOfMeasurement = new List<string>();
        public List<double> IngredientCalories = new List<double>();
        public List<double> IngredientCaloriesScaled = new List<double>();
        public List<string> recipeUnitsToDisplay = new List<string>();
        public List<string> Steps = new List<string>();
        public List<string> FoodGroups = new List<string>();

        public Recipe()
        {
            totalCalories = 0;
        }

        public static Dictionary<string, Tuple<double, string>> conversionsDict = new Dictionary<string, Tuple<double, string>>() {
                {"tablespoon", Tuple.Create(16.0, "cup") },
                {"tablespoons", Tuple.Create(16.0, "cup") },
                {"teaspoon", Tuple.Create(48.0, "cup") },
                {"teaspoons", Tuple.Create(48.0, "cup") },
        };

        public static StringBuilder displayRecipe(Recipe recipe)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("FULL RECIPE");
            sb.AppendLine("-------------------------------------------------------------");
            sb.AppendLine("Number of ingredients required: " + recipe.Num_ingredients);
            sb.AppendLine("Number of steps: " + recipe.Num_steps);
            sb.AppendLine("INGREDIENTS:");
            for (int i = 0; i < recipe.Ingredients.Count; i++)
            {
                sb.AppendLine("- " + recipe.IngredientQuantitiesScaled[i] + " " + recipe.recipeUnitsToDisplay[i] + " " + recipe.Ingredients[i] + " (" + recipe.FoodGroups[i] + ")  -  " + recipe.IngredientCaloriesScaled[i] + " calories");
            }
            sb.AppendLine("STEPS:");
            for (int i = 0; i < recipe.Steps.Count; i++)
            {
                sb.AppendLine((i + 1) + ". " + recipe.Steps[i]);
            }
            sb.AppendLine("\nTotal calories: " + recipe.totalCalories);
            return sb;
        }
    }
}
