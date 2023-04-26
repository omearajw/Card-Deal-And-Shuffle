using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    static class Advanced
    {
        public static void AdvancedMode()
        {
            Pack pack = new Pack();
            pack.shuffleCardPack(1);
            List<Card> cards = pack.dealCard(5);

            float num1 = cards[0].Value;
            float num2 = cards[2].Value;
            float num3 = cards[4].Value;
            var operator1 = ' ';
            var operator2 = ' ';

            if (cards[1].Suit == 1) { operator1 = '/'; }
            else if (cards[1].Suit == 2) { operator1 = '*'; }
            else if (cards[1].Suit == 3) { operator1 = '+'; }
            else if (cards[1].Suit == 4) { operator1 = '-'; }

            if (cards[3].Suit == 1) { operator2 = '/'; }
            else if (cards[3].Suit == 2) { operator2 = '*'; }
            else if (cards[3].Suit == 3) { operator2 = '+'; }
            else if (cards[3].Suit == 4) { operator2 = '-'; }

            //Prints question
            Console.WriteLine("\nHere is your question:\n");
            Console.WriteLine(num1 + operator1.ToString() + num2 + operator2.ToString() + num3);
            Console.WriteLine("\nGive your answer to 2 decimal places when dealing with decimals:\n");

            //Swaps operators and numbers based on BODMAS
            //If the operators are swapped then the numbers are swapped accordingly
            if (cards[1].Suit > cards[3].Suit)
            {
                var tempOp = operator1; operator1 = operator2; operator2 = tempOp;
                var tempNum = num1; num1 = num2; num2 = tempNum; tempNum = num2; num2 = num3; num3 = tempNum;
            }

            float result = 0;

            switch (operator1)
            {
                case '+':
                    result = num1 + num2; break;
                case '-':
                    result = num1 - num2; break;
                case '*':
                    result = num1 * num2; break;
                case '/':
                    result = num1 / num2; break;

            }

            switch (operator2)
            {
                case '+':
                    result = result + num3; break;
                case '-':
                    result = result - num3; break;
                case '*':
                    result = result * num3; break;
                case '/':
                    result = result / num3; break;
            }

            string formattedResult = "";
            if (result % 1 == 0) { formattedResult = result.ToString("F0"); }
            else { formattedResult = result.ToString("F2"); }


            string answer = Console.ReadLine();

            Console.WriteLine("\nThe answer was " + formattedResult);

            if (answer == formattedResult) { Console.WriteLine("Well done!"); }

            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Would you like to play again?\n1. Play again\n2. Main Menu");

            string selection = Console.ReadLine();
            Console.Clear();
            if (selection == "1") { Advanced.AdvancedMode(); }
            else { Menu.ShowMenu(); }
        }
            
    }
}
