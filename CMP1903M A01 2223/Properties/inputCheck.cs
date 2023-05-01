using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223.Properties
{
    internal class inputCheck
    {
        public static int GetMenuSelection(string message, int menuSize)
        {
            //Creates selection integer
            int selection;
            //Prints the message supplied when method was called
            Console.WriteLine(message);
            //Gets user inupt
            string input = Console.ReadLine().Trim();
            Console.Clear();

            //While the string is empty or not an integer or less than one or greater than the number of menu options
            while (string.IsNullOrEmpty(input) || !int.TryParse(input, out selection) || selection < 1 || selection > menuSize)
            {
                //Print the message
                Console.WriteLine(message);
                //Prints error message
                Console.WriteLine("Invalid input, please try again");
                //Gets user input again
                input = Console.ReadLine();
                Console.Clear();
            }

            //Returns valid selection
            return selection;
        }
    }
}
