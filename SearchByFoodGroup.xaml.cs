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
    /// Interaction logic for SearchByFoodGroup.xaml
    /// </summary>
    public partial class SearchByFoodGroup : Window
    {
        public SearchByFoodGroup()
        {
            InitializeComponent();
            foodGroupCB.Items.Add("Starchy foods");
            foodGroupCB.Items.Add("Vegetables and fruits");
            foodGroupCB.Items.Add("Dry beans, peas, lentils and soya");
            foodGroupCB.Items.Add("Chicken, fish, meat and eggs");
            foodGroupCB.Items.Add("Milk and dairy products");
            foodGroupCB.Items.Add("Fats and oil");
            foodGroupCB.Items.Add("Water");
        }

        //------------------------CODE ATTRIBUTION-----------------------------
        //The following layout of searching by food group name was taken from ChatGPT
        //Link: https://chatgpt.com/c/9306b1d7-1c3e-4f95-a870-bec97598a1d8 (Accessed 27 June 2024).
        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            if (foodGroupCB.SelectedItem == null)
            {
                MessageBox.Show("Please select a food group first.");
                return;
            }

            string selectedFoodGroup = foodGroupCB.SelectedItem.ToString();

            // Filter recipes that contain the selected food group
            var filteredRecipes = RecipeManager.allRecipes
                .Where(kv => kv.Value.FoodGroups.Contains(selectedFoodGroup))
                .Select(kv => kv.Key)  
                .ToList();

            if (filteredRecipes.Count == 0)
            {
                MessageBox.Show("No recipes found with the selected food group.");
                searchResultsLB.ItemsSource = null;
            }
            else
            {
                searchResultsLB.ItemsSource = filteredRecipes;  
            }
        }

    }
}
