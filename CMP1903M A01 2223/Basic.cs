using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    static class Basic
    {
        public static void BasicMode()
        {
            Pack pack = new Pack();
            pack.shuffleCardPack(1);
            List<Card> cards = pack.dealCard(3);
            Console.WriteLine(cards[0].Value);
            Console.WriteLine(cards[1].Suit);
            Console.WriteLine(cards[2].Value);

            int num1 = cards[0].Value;
            int num2 = cards[2].Value;
            var operator1 = ' ';

            if (cards[1].Suit == 1) { operator1 = '+'; }
            else if (cards[1].Suit == 2) { operator1 = '-'; }
            else if (cards[1].Suit == 3) { operator1 = '*'; }
            else if (cards[1].Suit == 4) { operator1 = '/'; }

            Console.WriteLine(num1);
            Console.WriteLine(operator1);
            Console.WriteLine(num2);

            Console.WriteLine(num1 + operator1.ToString() + num2);

            Console.WriteLine(num1 + operator1 + num2);

            Console.ReadLine();
        }
    }
}
