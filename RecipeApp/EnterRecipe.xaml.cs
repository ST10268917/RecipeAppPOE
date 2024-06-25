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
    /// Interaction logic for EnterRecipe.xaml
    /// </summary>
    public partial class EnterRecipe : Window
    {
        
        public EnterRecipe()
        {
            InitializeComponent();
        }

        InputValidation inputValidation = new InputValidation();

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            if (nameTB.Text.Length > 0 && numIngredientsTB.Text.Length > 0 && numStepsTB.Text.Length > 0)
            {
                int? numIngChecked = InputValidation.checkIntInput(numIngredientsTB.Text);
                int? numStepsChecked = InputValidation.checkIntInput(numStepsTB.Text);
                if (numIngChecked != null && numStepsChecked != null)
                {
                    Recipe recipe = new Recipe();
                    recipe.Name = nameTB.Text;
                    recipe.Num_ingredients = numIngChecked.Value;
                    recipe.Num_steps = numStepsChecked.Value;
                    RecipeManager.allRecipes.Add(recipe.Name, recipe);
                    for (int i = 0; i < recipe.Num_ingredients; i++)
                    {
                        this.Close();
                        IngredientDetails details = new IngredientDetails(i);
                        details.Show();
                    }
                }
            else
                {
                    MessageBox.Show("Please enter valid inputs");
                }                  
            }
        }
    }
}
