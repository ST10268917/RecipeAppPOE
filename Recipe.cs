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
        //The following layout  of implementing delegates was taken from OpenAI - ChatGPT 
        // Link: https://chatgpt.com/c/9306b1d7-1c3e-4f95-a870-bec97598a1d8 (Accessed 26 June 2024)
        // Define a delegate named CaloriesExceed300Handler that specifies the method signature for handlers of the
        // caloriesExceed300 event. The delegate takes a nullable double (double?) parameter that represents the total calories
        public delegate void CalorieCountExceededEventHandler(double totalCalories);

        // Declare the caloriesExceed300 event using the CaloriesExceed300Handler delegate. This event is triggered
        // when the calorie count exceeds 300. The event can be null if no handlers are attached.
        public event CalorieCountExceededEventHandler CalorieCountExceeded;

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
        public List<Step> Steps = new List<Step>();
        public List<string> FoodGroups = new List<string>();

        public Recipe()
        {
            totalCalories = 0;
        }

        public static Dictionary<string, Tuple<double, string>> conversionsDict = new Dictionary<string, Tuple<double, string>>() {
                {"Tablespoon", Tuple.Create(16.0, "Cup") },
                {"Tablespoons", Tuple.Create(16.0, "Cup") },
                {"Teaspoon", Tuple.Create(48.0, "Cup") },
                {"Teaspoons", Tuple.Create(48.0, "Cup") },
        };

        public static StringBuilder displayRecipe(Recipe recipe)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("FULL RECIPE");
            sb.AppendLine("-------------------------------------------------------------");
            sb.AppendLine("Number of ingredients required: " + recipe.Num_ingredients);
            sb.AppendLine("Number of steps: " + recipe.Num_steps);
            sb.AppendLine("\nINGREDIENTS:");
            for (int i = 0; i < recipe.Ingredients.Count; i++)
            {
                sb.AppendLine("- " + recipe.IngredientQuantitiesScaled[i] + " " + recipe.recipeUnitsToDisplay[i] + " " + recipe.Ingredients[i] + " (" + recipe.FoodGroups[i] + ")  -  " + recipe.IngredientCaloriesScaled[i] + " calories");
            }
            sb.AppendLine("\nSTEPS:");
            for (int i = 0; i < recipe.Steps.Count; i++)
            {
                sb.AppendLine((i + 1) + ". " + recipe.Steps[i]);
            }
            
            sb.AppendLine("\nTotal calories: " + recipe.totalCalories);
            if (recipe.totalCalories > 300)
            {
                sb.AppendLine("Note: The total calories of " + recipe.totalCalories + " for this recipe exceeds 300 calories");
            }
            sb.AppendLine(ProvideCalorieExplanation(recipe));
            return sb;
        }

        public void CheckCalorieCount()
        {
            if (totalCalories > 300)
            {
                CalorieCountExceeded?.Invoke(totalCalories.Value);
            }
        }

        public static string ProvideCalorieExplanation(Recipe recipe)
        {
            if (recipe.totalCalories <= 200)
            {
                return "This is a low-calorie dish, ideal for weight loss or maintenance diets.";
            }
            else if (recipe.totalCalories <= 300)
            {
                return "This dish has a moderate calorie count, suitable for everyday meals.";
            }
            else if (recipe.totalCalories <= 400)
            {
                return "While slightly above typical daily meal recommendations, it's still manageable.";
            }
            else if (recipe.totalCalories <= 600)
            {
                return "This is a high-calorie dish, best suited for post-workout meals or if you're trying to gain weight.";
            }
            else
            {
                return "This dish is very high in calories and should be consumed sparingly unless under specific dietary needs.";
            }
        }

    }

    public class Step
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; } = false;
    }

}
