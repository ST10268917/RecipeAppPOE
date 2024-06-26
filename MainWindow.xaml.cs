using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RecipeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            //------------------------CODE ATTRIBUTION-----------------------------
            //The following layout of exiting a WPF applicxation was taken from StackOverflow
            //Link: https://stackoverflow.com/questions/2820357/how-do-i-exit-a-wpf-application-programmatically (Accessed 25 June 2024).
            System.Windows.Application.Current.Shutdown();
        }

        private void enterRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            EnterRecipe enterRecipe = new EnterRecipe();
            enterRecipe.Show();
        }

        private void displayRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            Display recipeDisplay = new Display();
            recipeDisplay.Show();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearRecipe clearRecipe = new ClearRecipe();
            clearRecipe.Show();
        }
    }
}