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
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        public Search()
        {
            InitializeComponent();
        }

        //------------------------CODE ATTRIBUTION-----------------------------
        //The following layout of searching by ingredient name was taken from ChatGPT
        //Link: https://chatgpt.com/c/9306b1d7-1c3e-4f95-a870-bec97598a1d8 (Accessed 27 June 2024).
        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            // Trims whitespace from the input and converts it to lower case for case-insensitive comparison
            string searchIngredient = ingredientSearchTB.Text.Trim().ToLower();

            // Checks if the trimmed and converted input is null or empty, which means no valid input was provided
            if (string.IsNullOrEmpty(searchIngredient))
            {
                MessageBox.Show("Please enter an ingredient to search.");
                return; // Exits the method early if no input is provided
            }

            // Filters the dictionary of all recipes to find those that contain the specified ingredient.
            // This is done by checking each recipe's ingredient list for any ingredient that contains the search text.
            var filteredRecipes = RecipeManager.allRecipes
                .Where(kv => kv.Value.Ingredients.Any(ing => ing.ToLower().Contains(searchIngredient)))
                .ToList(); // Converts the results into a List for easier handling

            // Checks if the filtered list of recipes is empty, indicating no recipes contain the specified ingredient
            if (filteredRecipes.Count == 0)
            {
                MessageBox.Show("No recipes found with the specified ingredient.");
                searchResultsLB.ItemsSource = null; // Clears any existing items in the ListBox if no matches are found
            }
            else
            {
                // If recipes are found, the ListBox's item source is set to display the names of these recipes.
                searchResultsLB.ItemsSource = filteredRecipes.Select(kv => kv.Key); // Selects only the recipe names for display
            }
        }


    }
}
