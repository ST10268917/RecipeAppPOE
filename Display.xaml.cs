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

            // Printing the sorted keys
            foreach (var key in sortedKeys)
            {
                recipesCB.Items.Add(key);
            }
        }

        private void recipesCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string recipeToDisplay = recipesCB.SelectedItem.ToString();
            displayTB.Text = displayRecipe(RecipeManager.allRecipes[recipeToDisplay]).ToString();
        }

        public StringBuilder displayRecipe(Recipe recipe)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("FULL RECIPE");
            sb.AppendLine("-------------------------------------------------------------");
            sb.AppendLine("Number of ingredients required: " + recipe.Num_ingredients);
            sb.AppendLine("Number of steps: " + recipe.Num_steps);
            sb.AppendLine("INGREDIENTS:");
            for (int i = 0; i < recipe.Num_ingredients; i++)
            {
             //   sb.AppendLine("- " + recipe.IngredientQuantitiesScaled[i] + " " + recipe.recipeUnitsToDisplay[i] + " " + recipe.Ingredients[i] + " (" + recipe.FoodGroups[i] + ")  -  " + recipe.IngredientCalories[i] + " calories");
            }
            sb.AppendLine("STEPS:");
            for (int i = 0; i < recipe.Num_steps; i++)
            {
                sb.AppendLine((i + 1) + ". " + recipe.Steps[i]);
            }
            sb.AppendLine("\nTotal calories: " + recipe.totalCalories);
            return sb;
        }
    }
}
