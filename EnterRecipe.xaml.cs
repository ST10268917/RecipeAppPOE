using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace RecipeApp
{
    /// <summary>
    /// Interaction logic for EnterRecipe.xaml
    /// Handles user inputs for creating a new recipe and stores it in the application's recipe manager.
    /// </summary>
    public partial class EnterRecipe : Window
    {
        private Recipe recipe;  // Holds the current recipe being entered.
        private int currentIngredientIndex = 0;  // Index to track the number of ingredients entered.
        private int currentStepIndex = -1;  // Index to track the number of steps entered, starts at -1 as increment happens before use.

        public EnterRecipe()
        {
            InitializeComponent();  // Initialize component from XAML.
        }

        InputValidation inputValidation = new InputValidation();  // Utility to validate user input.

        /// <summary>
        /// Handles the click event of the submit button for the recipe form.
        /// Validates and processes the recipe name, number of ingredients, and steps.
        /// </summary>
        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            // Ensure all fields are filled before processing.
            if (nameTB.Text.Length > 0 && numIngredientsTB.Text.Length > 0 && numStepsTB.Text.Length > 0)
            {
                // Validate numeric inputs for number of ingredients and steps.
                int? numIngChecked = InputValidation.checkIntInput(numIngredientsTB.Text);
                int? numStepsChecked = InputValidation.checkIntInput(numStepsTB.Text);

                if (RecipeManager.allRecipes.ContainsKey(nameTB.Text.ToUpper()))
                {
                    MessageBox.Show("A recipe with the name " + nameTB.Text + " already exists. Please use a different name.");
                } else
                {
                    // Process the recipe if inputs are valid.
                    if (numIngChecked != null && numStepsChecked != null)
                    {
                        recipe = new Recipe
                        {
                            Name = nameTB.Text.ToUpper(),
                            Num_ingredients = numIngChecked.Value,
                            Num_steps = numStepsChecked.Value
                        };
                        RecipeManager.allRecipes.Add(recipe.Name, recipe);  // Add recipe to the global recipe manager.

                        this.Hide();  // Hide the entry form.
                        ShowIngredientDetailsForm();  // Start ingredient entry process.
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid inputs");  // Alert for invalid numeric inputs.
                    }
                }         
            }
            else
            {
                MessageBox.Show("Please fill in all fields");  // Alert for incomplete form.
            }
        }

        /// <summary>
        /// Shows the form for entering details of the next ingredient.
        /// </summary>
        private void ShowIngredientDetailsForm()
        {
            if (currentIngredientIndex < recipe.Num_ingredients)
            {
                // Create and show the ingredient details form for the next ingredient.
                IngredientDetails details = new IngredientDetails(recipe.Name, currentIngredientIndex);
                details.IngredientSubmitted += Details_IngredientSubmitted;  // Subscribe to ingredient submission event.
                details.Show();
            }
            else
            {
                // No more ingredients to enter; proceed to step entry.
                MessageBox.Show("All ingredients entered");
                Details_StepSubmitted();
            }
        }

        /// <summary>
        /// Event handler for when an ingredient has been submitted.
        /// Advances to the next ingredient or transitions to entering steps.
        /// </summary>
        private void Details_IngredientSubmitted()
        {
            currentIngredientIndex++;  // Move to the next ingredient.
            ShowIngredientDetailsForm();  // Show form for next ingredient.
        }

        /// <summary>
        /// Event handler for when all ingredients have been entered.
        /// Advances to entering recipe steps.
        /// </summary>
        private void Details_StepSubmitted()
        {
            currentStepIndex++;  // Move to the next step.
            ShowStepForm();  // Show form for next step.
        }

        /// <summary>
        /// Shows the form for entering details of the next step in the recipe.
        /// </summary>
        private void ShowStepForm()
        {
            if (currentStepIndex < recipe.Num_steps)
            {
                // Create and show the steps details form for the next step.
                StepsDetails stepsDetails = new StepsDetails(recipe.Name, currentStepIndex);
                stepsDetails.StepSubmitted += Details_StepSubmitted;  // Subscribe to step submission event.
                stepsDetails.Show();
            }
            else
            {
                // All steps have been entered; finalize recipe creation.
                MessageBox.Show("All steps entered");
                MessageBox.Show("The recipe has successfully been saved");  // Notify user of successful save.
            }
        }
    }
}
