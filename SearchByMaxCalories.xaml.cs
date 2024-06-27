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
    /// Interaction logic for SearchByMaxCalories.xaml
    /// </summary>
    public partial class SearchByMaxCalories : Window
    {
        public SearchByMaxCalories()
        {
            InitializeComponent();
        }

        //------------------------CODE ATTRIBUTION-----------------------------
        //The following layout of searching by max calories was taken from ChatGPT
        //Link: https://chatgpt.com/c/9306b1d7-1c3e-4f95-a870-bec97598a1d8 (Accessed 27 June 2024).
        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(maxCaloriesSearchTB.Text.Trim(), out int maxCalories))
            {
                MessageBox.Show("Please enter a valid number for calories.");
                return;
            }

            // Filter recipes that have total calories less than or equal to the specified maximum
            var filteredRecipes = RecipeManager.allRecipes
                                               .Where(kv => kv.Value.totalCalories.HasValue && kv.Value.totalCalories.Value <= maxCalories)
                                               .Select(kv => kv.Key)  
                                               .ToList();

            if (filteredRecipes.Count == 0)
            {
                MessageBox.Show("No recipes found under the specified calorie count.");
                searchResultsLB.ItemsSource = null;
            }
            else
            {
                searchResultsLB.ItemsSource = filteredRecipes;  
            }
        }

    }
}
