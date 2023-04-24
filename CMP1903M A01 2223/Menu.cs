using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Menu
    {
        public int ShowMenu()
        {
            Console.WriteLine("1. Instructions \n2. Basic \n3. Advanced \n4. Quit");
            int selection = int.Parse(Console.ReadLine());
            Console.Clear();
            return selection;
        }
        public void MenuSelection(int selection)
        {
            if (selection == 1)
            {
                Console.WriteLine("INSTRUCTIONS\n" + "Here is a simple explaination as to how this program works:\n" +
                "1. Select a difficulty - either basic or advanced.\n" +
                "   Basic uses 3 cards - 2 numbers and 1 operator.\n" +
                "   Advanced uses 5 cards - 3 numbers and 2 operators.\n" +
                "2. Input answer to displayed question.\n" +
                "3. You'll be brought back to the menu where you can play again.");
                Console.ReadLine();
                ShowMenu();
            }
            else if (selection == 2)
            {
                Console.WriteLine("BASIC MODE");
                Basic.BasicMode();
            }
        }
    }
}
