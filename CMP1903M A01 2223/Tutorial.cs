using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    static class Tutorial
    {
        public static void TutorialMethod()
        {
            //Prints Instructions
            Console.WriteLine("INSTRUCTIONS\n" + "Here is a simple explaination as to how this program works:\n" +
                "1. Select a difficulty - either basic or advanced.\n" +
                "   Basic uses 3 cards - 2 numbers and 1 operator.\n" +
                "   Advanced uses 5 cards - 3 numbers and 2 operators.\n" +
                "2. Input answer to displayed question.\n" +
                "3. Either play again or return to the main menu.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
