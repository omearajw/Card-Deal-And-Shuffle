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
            for (int i=0 ; i < 3; i++)
            {
                Console.WriteLine((cards[i]).Value);
            }
            Console.ReadLine();
        }
    }
}
