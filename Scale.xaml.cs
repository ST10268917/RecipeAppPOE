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
    /// Interaction logic for Scale.xaml
    /// </summary>
    public partial class Scale : Window
    {
        Recipe recipeToScale;

        public Scale()
        {
            InitializeComponent();
            var sortedKeys = RecipeManager.allRecipes.Keys.OrderBy(key => key);

            // Printing the sorted keys
            foreach (var key in sortedKeys)
            {
                recipesCB.Items.Add(key);
            }
        }

        private void halfButton_Click(object sender, RoutedEventArgs e)
        {
           
            if (recipesCB.SelectedItem != null)
            {
                ScaleAndConvertUnits(recipeToScale, "half");
                
            } else
            {
                MessageBox.Show("Please select a recipe to scale");
            }
        }

        private void doubleButton_Click(object sender, RoutedEventArgs e)
        {
            if (recipesCB.SelectedItem != null)
            {
                ScaleAndConvertUnits(recipeToScale, "double");
            }
            else
            {
                MessageBox.Show("Please select a recipe to scale");
            }
        }

        private void tripleButton_Click(object sender, RoutedEventArgs e)
        {
            if (recipesCB.SelectedItem != null)
            {
                ScaleAndConvertUnits(recipeToScale, "triple");
            }
            else
            {
                MessageBox.Show("Please select a recipe to scale");
            }
        }

        //METHOD 9:
        //This method halves the ingredient quantities 
        public void halfRecipe(Recipe recipe)
        {
            for (int i = 0; i < recipe.Num_ingredients; i++)
            {
                recipe.IngredientQuantitiesScaled[i] = recipe.IngredientQuantitiesScaled[i] * 0.5;
            }
        }

        //METHOD 10:
        //This method doubles the ingredient quantities 
        public void doubleRecipe(Recipe recipe)
        {
            for (int i = 0; i < recipe.Num_ingredients; i++)
            {
                recipe.IngredientQuantitiesScaled[i] = recipe.IngredientQuantitiesScaled[i] * 2;
            }
        }

        //METHOD 11:
        //This method triples the ingredient quantities 
        public void tripleRecipe(Recipe recipe)
        {
            for (int i = 0; i < recipe.Num_ingredients; i++)
            {
                recipe.IngredientQuantitiesScaled[i] = recipe.IngredientQuantitiesScaled[i] * 3;
            }
        }

        //METHOD 12:
        /*
       * The `ScaleAndConvertUnits` method in the Recipe application is designed to adjust the quantities of
       * ingredients based on a specified scaling factor—either 'half', 'double', or 'triple'.
       * Once the quantities are scaled, the method checks each ingredient to determine if the new quantity 
       * reaches a threshold that necessitates a conversion to a different unit of measurement, based on 
       * predefined conversion rules. If so, the method performs the conversion, ensuring that both the 
       * quantities and their corresponding units are appropriately adjusted. After scaling and converting 
       * the units, the updated recipe is automatically displayed to the user. 
       */
        public void ScaleAndConvertUnits(Recipe recipe, string scaleFactor)
        {
            switch (scaleFactor)
            {
                case "half":
                    halfRecipe(recipe);
                    for (int i = 0; i < recipe.Num_ingredients; i++)
                    {
                        recipe.IngredientCaloriesScaled[i] = recipe.IngredientCaloriesScaled[i] * 0.5;
                    }
                    MessageBox.Show("The recipe has been halved");
                    break;
                case "double":
                    doubleRecipe(recipe);
                    for (int i = 0; i < recipe.Num_ingredients; i++)
                    {
                        recipe.IngredientCaloriesScaled[i] = recipe.IngredientCaloriesScaled[i] * 2;
                    }
                    MessageBox.Show("The recipe has been doubled.");
                    break;
                case "triple":
                    tripleRecipe(recipe);
                    for (int i = 0; i < recipe.Num_ingredients; i++)
                    {
                        recipe.IngredientCaloriesScaled[i] = recipe.IngredientCaloriesScaled[i] * 3;
                    }
                    MessageBox.Show("The recipe has been tripled.");
                    break;
                //If the user enters an invalid scale factor, they will be informed
                default:
                    break;
            }

            for (int i = 0; i < recipe.Ingredients.Count; i++)
            {
                string currentUnit = recipe.recipeUnitsToDisplay[i];
                double quantity = recipe.IngredientQuantitiesScaled[i];

                if (Recipe.conversionsDict.ContainsKey(currentUnit) && quantity >= Recipe.conversionsDict[currentUnit].Item1)
                {
                    recipe.IngredientQuantitiesScaled[i] = quantity / Recipe.conversionsDict[currentUnit].Item1;
                    recipe.recipeUnitsToDisplay[i] = Recipe.conversionsDict[currentUnit].Item2;
                }
            }
            displayTB.Text = Recipe.displayRecipe(recipe).ToString();
        }

        private void recipesCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            recipeToScale = RecipeManager.allRecipes[recipesCB.SelectedItem.ToString()];
        }
        //____________________ CODE ATTRIBUTION _______________________________________
        //The layout above of how to convert units of measurements when they reach a certain threshold was taken from OpenAI - ChatGPT 
        // I looked at the logic, adapted it to suit my code and implemented it (Accessed 15 April 2024)
    }
}
