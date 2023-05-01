﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CMP1903M_A01_2223.Properties;

namespace CMP1903M_A01_2223
{
    static class Advanced
    {
        public static void AdvancedMode()
        {
            //Creates a new pack
            Pack pack = new Pack();
            //Shuffles the pack with the Fisher-Yates shuffle
            pack.shuffleCardPack(1);
            //Deals the 5 cards
            List<Card> cards = pack.dealCard(5);

            //Assigns the values to the variables
            float num1 = cards[0].Value;
            float num2 = cards[2].Value;
            float num3 = cards[4].Value;
            var operator1 = ' ';
            var operator2 = ' ';

            //Assigns the operator based on the suit of the card
            if (cards[1].Suit == 1) { operator1 = '/'; }
            else if (cards[1].Suit == 2) { operator1 = '*'; }
            else if (cards[1].Suit == 3) { operator1 = '+'; }
            else if (cards[1].Suit == 4) { operator1 = '-'; }

            //Assigns the second operator
            if (cards[3].Suit == 1) { operator2 = '/'; }
            else if (cards[3].Suit == 2) { operator2 = '*'; }
            else if (cards[3].Suit == 3) { operator2 = '+'; }
            else if (cards[3].Suit == 4) { operator2 = '-'; }

            //Prints question
            Console.WriteLine("ADVANCED MODE\n");
            Console.WriteLine("\nHere is your question:\n");
            Console.WriteLine(num1 + operator1.ToString() + num2 + operator2.ToString() + num3);
            Console.WriteLine("\nGive your answer to 2 decimal places when dealing with decimals:\n");

            //Swaps operators and numbers based on BODMAS
            //If the operators are swapped then the numbers are also swapped accordingly
            if (cards[1].Suit > cards[3].Suit)
            {
                var tempOp = operator1; operator1 = operator2; operator2 = tempOp;
                var tempNum = num1; num1 = num2; num2 = tempNum; tempNum = num2; num2 = num3; num3 = tempNum;
            }

            //Creates the result variable
            float result = 0;

            //Carries out a different calculation based on the operator
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

            //Carries out the second half of the calculation
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

            //Formats the result based on whether the result has decimals
            string formattedResult = "";
            if (result % 1 == 0) { formattedResult = result.ToString("F0"); }
            else { formattedResult = result.ToString("F2"); }

            //Gets the users answer
            string answer = Console.ReadLine();

            //Prints answer
            Console.WriteLine("\nThe answer was " + formattedResult);

            //Checks if answer was correct and prints a 'Well done!' Message
            if (answer == formattedResult) { Console.WriteLine("Well done!"); }

            Console.ReadLine();

            Console.Clear();

            //Gets the users response
            int selection = inputCheck.GetMenuSelection("Would you like to play again?\n1. Play again\n2. Main Menu\n", 2);

            //If the user plays again then the advancedMode method is called again
            if (selection == 1) { Advanced.AdvancedMode(); }
            //If the user shows menu then the program returns to the menu
            else if (selection == 2) { Console.Clear(); }

        }
            
    }
}
