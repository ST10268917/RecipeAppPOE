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
            string searchIngredient = ingredientSearchTB.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchIngredient))
            {
                MessageBox.Show("Please enter an ingredient to search.");
                return;
            }

            var filteredRecipes = RecipeManager.allRecipes
                .Where(kv => kv.Value.Ingredients.Any(ing => ing.ToLower().Contains(searchIngredient)))
                .ToList();

            if (filteredRecipes.Count == 0)
            {
                MessageBox.Show("No recipes found with the specified ingredient.");
                searchResultsLB.ItemsSource = null;
            }
            else
            {
                searchResultsLB.ItemsSource = filteredRecipes.Select(kv => kv.Key);
            }
        }


    }
}
