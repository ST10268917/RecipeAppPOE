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
            displayTB.Text = Recipe.displayRecipe(RecipeManager.allRecipes[recipeToDisplay]).ToString();
        }

        

        

    }
}
