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
    /// Interaction logic for StepsDetails.xaml
    /// </summary>
    public partial class StepsDetails : Window
    {
        public delegate void StepSubmittedHandler();
        public event StepSubmittedHandler StepSubmitted;
        public string recipeName;
        public StepsDetails(string name, int stepNum)
        {
            InitializeComponent();
            titleLabel.Content = "Step " + (stepNum + 1);
            recipeName = name;
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            // Check if any input field is empty or if the ComboBox has no selected item
            if (string.IsNullOrWhiteSpace(descriptionTB.Text))
            {
                MessageBox.Show("Please fill all fields");
                return; // Return early to prevent further execution
            }

            // Assuming all validations pass, proceed to update the recipe
            Recipe recipe = RecipeManager.allRecipes[recipeName];
            recipe.Steps.Add(descriptionTB.Text);
            StepSubmitted?.Invoke();
            this.Close();
        }
    }
}
