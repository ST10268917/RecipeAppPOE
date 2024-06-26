using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for IngredientDetails.xaml
    /// </summary>
    public partial class IngredientDetails : Window
    {
        public delegate void IngredientSubmittedHandler();
        public event IngredientSubmittedHandler IngredientSubmitted;
        public string recipeName;
        public IngredientDetails(string name, int ingredientNum)
        {
            InitializeComponent();
            titleLabel.Content = "Ingredient " + (ingredientNum + 1) + " details";
            recipeName = name;
            foodGroupCB.Items.Add("Starchy foods");
            foodGroupCB.Items.Add("Vegetables and fruits");
            foodGroupCB.Items.Add("Dry beans, peas, lentils and soya");
            foodGroupCB.Items.Add("Chicken, fish, meat and eggs");
            foodGroupCB.Items.Add("Milk and dairy products");
            foodGroupCB.Items.Add("Fats and oil");
            foodGroupCB.Items.Add("Water");
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            // Check if any input field is empty or if the ComboBox has no selected item
            if (string.IsNullOrWhiteSpace(nameTB.Text) ||
                string.IsNullOrWhiteSpace(quantityTB.Text) ||
                string.IsNullOrWhiteSpace(unitOfMeasurementTB.Text) ||
                string.IsNullOrWhiteSpace(caloriesTB.Text) ||
                foodGroupCB.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields and select a food group.");
                return; // Return early to prevent further execution
            }

            // Proceed with further validation if fields are not empty
            int? quantityChecked = InputValidation.checkIntInput(quantityTB.Text);
            int? caloriesChecked = InputValidation.checkIntInput(caloriesTB.Text);

            if (quantityChecked == null || caloriesChecked == null)
            {
                MessageBox.Show("Please enter valid numbers for quantity and calories.");
                return; // Return early if the numerical inputs are not valid
            }

            // Assuming all validations pass, proceed to update the recipe
            Recipe recipe = RecipeManager.allRecipes[recipeName];
            recipe.Ingredients.Add(nameTB.Text);
            recipe.IngredientQuantities.Add(quantityChecked.Value);
            recipe.IngredientUnitsOfMeasurement.Add(unitOfMeasurementTB.Text);
            recipe.IngredientCalories.Add(caloriesChecked.Value);
            recipe.totalCalories += caloriesChecked;
            recipe.FoodGroups.Add(foodGroupCB.SelectedItem.ToString());

            IngredientSubmitted?.Invoke();
            this.Close();
        }

        public string determineFoodGroupMessage(string foodGroup)
        {
            switch (foodGroup)
            {
                case "Starchy foods":
                    return "Starchy foods are a good source of energy and the main source of a range of nutrients in our diet.";
                case "Vegetables and fruits":
                    return "Rich in vitamins, minerals, and fiber, vegetables and fruits are essential for good health and may reduce the risk of disease.";
                case "Dry beans, peas, lentils and soya":
                    return "These are great sources of protein and fiber, which help in muscle repair and can aid digestion.";
                case "Chicken, fish, meat and eggs":
                    return "Important sources of high-quality protein and other essential nutrients like omega-3 fatty acids (from fish)";
                case "Milk and dairy products":
                    return "These provide calcium, which is essential for healthy bones and teeth, as well as being a source of protein and vitamins.";
                case "Fats and oil":
                    return "Essential for long-term energy, absorption of certain vitamins, and cell function. Use in moderation.";
                case "Water":
                    return "Essential for life, water plays a critical role in every bodily function, from digestion to temperature regulation.";
                default:
                    return null;
            }
        }

        private void foodGroupCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foodGroupDescr.Text = determineFoodGroupMessage((string)foodGroupCB.SelectedItem);
        }
    }

    
}
