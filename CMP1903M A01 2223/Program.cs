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
            while (true)
            {
                int selection = Menu.ShowMenu();
                Menu.MenuSelection(selection);  
            }
        }
    }
}
