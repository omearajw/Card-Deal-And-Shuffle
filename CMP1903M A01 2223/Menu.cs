using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMP1903M_A01_2223.Properties;

namespace CMP1903M_A01_2223
{
    static class Menu
    {
        public static int ShowMenu()
        {
            //Calls the input check class to check that the input is valid
            int selection = inputCheck.GetMenuSelection("1. Instructions \n2. Basic \n3. Advanced \n4. Quit\n", 4);
            //Returns the selection back to the man program
            return selection;
        }
        public static void MenuSelection(int selection)
        {
            //A simple set of if statements to call specific functions based on menu selection
            if (selection == 1)
            {
                Tutorial.TutorialMethod();
            }
            else if (selection == 2)
            {
                Basic.BasicMode();
            }
            else if (selection == 3)
            {
                Advanced.AdvancedMode();
            }
            else if (selection == 4)
            {
                Console.WriteLine("Thanks for playing!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
