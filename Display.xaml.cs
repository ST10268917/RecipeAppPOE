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
using System.Windows.Shapes;

namespace RecipeApp
{
    /// <summary>
    /// Interaction logic for Display.xaml
    /// </summary>
    public partial class Display : Window
    {
        public Display()
        {
            InitializeComponent();
            var sortedKeys = RecipeManager.allRecipes.Keys.OrderBy(key => key);

            //------------------------CODE ATTRIBUTION-----------------------------
            //The following layout of using tags with a combo box item was taken from ChatGPT
            //Link: https://chatgpt.com/c/9306b1d7-1c3e-4f95-a870-bec97598a1d8 (Accessed 26 June 2024).

            // Printing the sorted keys with other details
            foreach (var key in sortedKeys)
            {
                var item = new ComboBoxItem
                {
                    Content = key + " (" + RecipeManager.allRecipes[key].totalCalories + " calories, " + RecipeManager.allRecipes[key].Num_ingredients + " ingredients, " + RecipeManager.allRecipes[key].Num_steps + " steps)",
                    Tag = key
                };
                recipesCB.Items.Add(item);
            }

        }

        private void recipesCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (recipesCB.SelectedItem is ComboBoxItem selectedItem)
            {
                string recipeName = selectedItem.Tag.ToString();
                Recipe recipeToDisplay = RecipeManager.allRecipes[recipeName];
                displayTB.Text = displayRecipe(recipeToDisplay).ToString();

                //------------------------CODE ATTRIBUTION-----------------------------
                //The following layout of using the list view was taken from ChatGPT
                //Link: https://chatgpt.com/c/9306b1d7-1c3e-4f95-a870-bec97598a1d8 (Accessed 26 June 2024).
                stepsListView.ItemsSource = recipeToDisplay.Steps;
            }
        }

        private StringBuilder displayRecipe(Recipe recipe)
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

            //------------------------CODE ATTRIBUTION-----------------------------
            //The following layout of using a StackPanel and checkboxes was taken from ChatGPT
            //Link: https://chatgpt.com/c/9306b1d7-1c3e-4f95-a870-bec97598a1d8 (Accessed 26 June 2024).
           
            sb.AppendLine("\nTotal calories: " + recipe.totalCalories);
            if (recipe.totalCalories > 300)
            {
                sb.AppendLine("Note: The total calories of " + recipe.totalCalories + " for this recipe exceeds 300 calories");
            }
            sb.AppendLine(Recipe.ProvideCalorieExplanation(recipe));
            sb.AppendLine("\nSTEPS:");
            return sb;
        }

  

    }
}
