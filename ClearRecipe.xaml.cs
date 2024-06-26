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
    /// Interaction logic for ClearRecipe.xaml
    /// </summary>
    public partial class ClearRecipe : Window
    {
        public ClearRecipe()
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

        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            if (recipesCB.SelectedItem != null)
            {
                string recipeToClear = recipesCB.SelectedItem.ToString();
                //------------------------CODE ATTRIBUTION-----------------------------
                //The following layout of implementing a confirmation MessageBox was taken from ChatGPT
                //Link: https://chatgpt.com/c/9306b1d7-1c3e-4f95-a870-bec97598a1d8 (Accessed 26 June 2024).
                // Display a confirmation MessageBox
                MessageBoxResult result = MessageBox.Show("Are you sure you want to clear the selected recipe?",
                                                          "Confirm Clear",
                                                          MessageBoxButton.YesNo,
                                                          MessageBoxImage.Question);
                // Check the user's response
                if (result == MessageBoxResult.Yes)
                {
                    RecipeManager.allRecipes.Remove(recipeToClear);
                    MessageBox.Show("The recipe has been cleared");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The recipe is still available");
                }
            }
            else
            {
                MessageBox.Show("Please select a recipe to clear");
            }
        }
    }
}
