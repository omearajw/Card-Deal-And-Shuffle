using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction
            Console.WriteLine("Welcome to MathsTutor!");
            Console.ReadLine();
            Console.Clear();
            //The program runs indefinetly until closed or quit
            while (true)
            {
                //Menu is called in order to make selection
                int selection = Menu.ShowMenu();
                Console.Clear();
                //Selection is passed back into the menu
                Menu.MenuSelection(selection);  
            }
        }
    }
}
