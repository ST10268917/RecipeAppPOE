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
        private Recipe recipe;
        private int currentIngredientIndex = 0;
        private int currentStepIndex = -1;

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
                    recipe = new Recipe();
                    recipe.Name = nameTB.Text;
                    recipe.Num_ingredients = numIngChecked.Value;
                    recipe.Num_steps = numStepsChecked.Value;
                    RecipeManager.allRecipes.Add(recipe.Name, recipe);
                    // Close the current form and show the first IngredientDetails form
                    this.Hide();
                    ShowIngredientDetailsForm();
                }
            else
                {
                    MessageBox.Show("Please enter valid inputs");
                }                  
            }
        }

        private void ShowIngredientDetailsForm()
        {
            if (currentIngredientIndex < recipe.Num_ingredients)
            {
                IngredientDetails details = new IngredientDetails(recipe.Name, currentIngredientIndex);
                details.IngredientSubmitted += Details_IngredientSubmitted;  // Subscribe to the event
                details.Show();
            }
            else
            {
                MessageBox.Show("All ingredients entered");
                Details_StepSubmitted();
            }
        }

        private void Details_IngredientSubmitted()
        {
            currentIngredientIndex++; // Increment to load the next ingredient
            ShowIngredientDetailsForm(); // Show next ingredient form
        }

        private void Details_StepSubmitted()
        {
            currentStepIndex++;
            ShowStepForm();
        }

        private void ShowStepForm()
        {
            if (currentStepIndex < recipe.Num_steps)
            {
                StepsDetails stepsDetails = new StepsDetails(recipe.Name, currentStepIndex);
                stepsDetails.StepSubmitted += Details_StepSubmitted;  // Subscribe to the event
                stepsDetails.Show();
            }
            else
            {
                MessageBox.Show("All steps entered");
                MessageBox.Show("The recipe has successfully been saved");
            }
        }
    }
}
