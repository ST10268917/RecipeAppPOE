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
        public IngredientDetails(int ingredientNum)
        {
            InitializeComponent();
            titleLabel.Content = "Ingredient " + (ingredientNum + 1) + " details";
        }

        
    }
}
