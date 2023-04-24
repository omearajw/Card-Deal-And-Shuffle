using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        public void Run()
        {
            // Create a Pack object
            Pack myPack = new Pack();

            // Shuffle the cards using different shuffle types
            Console.WriteLine("Shuffling cards using type 1...");
            myPack.shuffleCardPack(1);
            Console.WriteLine("Shuffling cards using type 2...");
            myPack.shuffleCardPack(2);

            // Deal some cards
            Console.WriteLine("Dealing one card...");
            Card dealtCard = myPack.dealCard();
            Console.WriteLine($"Dealt card: {dealtCard.Value}, {dealtCard.Suit}");

            Console.WriteLine("Dealing five cards...");
            var dealtCards = myPack.dealCard(5);
            Console.WriteLine("Dealt cards:");
            foreach (var card in dealtCards)
            {
                Console.WriteLine($"{card.Value}, {card.Suit}");
            }
            Console.ReadLine();
        }
    }
}