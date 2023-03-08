using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        private static List<Card> pack;

        static Pack()
        {
            //Initialise the card pack here
            pack = new List<Card>();
            //For loop for each suit
            for (int suit = 1; suit <= 4; suit++)
            {
                //For loop for every value of card (1-13)
                for (int value = 1; value <= 13; value++)
                {
                    //Initialises a new card with the current suit and value
                    Card newCard = new Card
                    {
                        Suit = suit,
                        Value = value
                    };
                    //Adds the new card to the pack
                    pack.Add(newCard);
                }
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            Random rand = new Random();
            //Fisher-Yates shuffle
            if (typeOfShuffle == 1)
            {
                //Creates a temporary replica pack of cards
                List<Card> tempPack = new List<Card>(pack);
                //Creates an empty pack of cards to put the shuffled cards into
                List<Card> shuffledPack = new List<Card>();
                //For loop which counts down from 52
                for (int count = 52; count > 0; count--)
                {
                    //Randomly picks a card
                    int currentCard = rand.Next(0, tempPack.Count);
                    //Adds the card to the shuffled pack
                    shuffledPack.Add(tempPack[currentCard]);
                    //Removes the card from the temp pack
                    tempPack.RemoveAt(currentCard);

                }
                //Sets the pack to the new shuffled pack
                pack = shuffledPack;
                return true;

            }
            //Riffle shuffle
            else if (typeOfShuffle == 2)
            {
                //Creates a temporary replica pack of cards
                List<Card> tempPack = new List<Card>(pack);
                //Creates an empty pack of cards to put the shuffled cards into
                List<Card> shuffledPack = new List<Card>();
                //Creates an empty pack of cards to put the left cards into
                List<Card> leftHalf = new List<Card>();
                //Creates an empty pack of cards to put the right cards into
                List<Card> rightHalf = new List<Card>();
                int count = 0;
                //Iterates through the amount of cards in the pack
                for (int i = 0; i < tempPack.Count; i++)
                {
                    //Alternates between adding each card to the left or right pack
                    if (count == 0)
                    {
                        rightHalf.Add((Card)tempPack[i]);
                        count++;
                    }
                    else if (count == 1)
                    {
                        leftHalf.Add((Card)tempPack[i]);
                        count--;
                    }
                }
                //Adds all the left cards
                foreach (Card card in leftHalf)
                {
                    shuffledPack.Add(card);
                }
                //Adds all the right cards
                foreach (Card card in rightHalf)
                {
                    shuffledPack.Add(card);
                }
                pack = shuffledPack;
                return true;
            }
            else if (typeOfShuffle == 3)
            {
                return true;
            }
            return true;
        }
        public static Card dealCard()
        {
            //Deals one card
            //If there are no cards in the pack then return null
            if (pack.Count == 0)
            {
                return null;
            }
            //Creates new card from the first card in the pack
            Card dealtCard = pack[0];
            //Removes the card thats been dealt
            pack.RemoveAt(0);
            //Returns the card
            return dealtCard;
        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            //If there aren't enough cards in the pack then return null
            if (pack.Count-amount <= 0)
            {
                return null;
            }
            //Creates a new hand(pack) for dealt cards
            List<Card> dealtCards = new List<Card>();
            //Iterates adding a card to the hand and removing it from the pack
            for (int num = 0; num < amount; num++)
            {
                dealtCards.Add(pack[0]);
                pack.RemoveAt(0);
            }
            return dealtCards;
        }
    }
}
