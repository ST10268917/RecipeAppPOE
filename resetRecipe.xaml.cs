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
    /// Interaction logic for resetRecipe.xaml
    /// </summary>
    public partial class resetRecipe : Window
    {
        public resetRecipe()
        {
            InitializeComponent();
            var sortedKeys = RecipeManager.allRecipes.Keys.OrderBy(key => key);

            // Printing the sorted keys
            foreach (var key in sortedKeys)
            {
                recipesCB.Items.Add(key);
            }
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {

            if (recipesCB.SelectedItem != null)
            {
                Recipe recipeToReset = RecipeManager.allRecipes[recipesCB.SelectedItem.ToString()];
                for (int i = 0; i < recipeToReset.Ingredients.Count; i++)
                {
                    recipeToReset.IngredientQuantitiesScaled[i] = recipeToReset.IngredientQuantities[i];
                    recipeToReset.IngredientCaloriesScaled[i] = recipeToReset.IngredientCalories[i];
                }
                MessageBox.Show("Recipe - " + recipeToReset.Name + " -  quantities have been reset");
                displayTB.Text = Recipe.displayRecipe(recipeToReset).ToString();
            }
            else
            {
                MessageBox.Show("Please select a recipe to reset");
            }
            
        }
    }
}
