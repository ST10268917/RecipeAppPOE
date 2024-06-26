using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RecipeApp
{
    public class InputValidation
    {
        //METHOD 1:
        //This method validates user input. When a user is required to enter an int input, it ensures they have done accordingly.
        public static int? checkIntInput(string userInput)
        {
            int? userInputInt = null;
            try
            {
                userInputInt = Convert.ToInt32(userInput);
            }
            catch (Exception)
            {
            }
            return userInputInt;
        }

        //METHOD 2:
        //This method validates user input. When a user is required to enter an double input, it ensures they have done accordingly.
        public static double? checkDoubleInput(string userInput)
        {
            double? userInputDouble = null;
            try
            {
                userInputDouble = Convert.ToDouble(userInput);
            }
            catch (Exception)
            {
            }
            return userInputDouble;
        }
    }
}
