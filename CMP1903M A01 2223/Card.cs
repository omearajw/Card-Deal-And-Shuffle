using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4

        //Makes private values to avoid recursion
        private int value;
        private int suit;

        public int Value
        {
            //Get method for card value
            get
            {
                return value;
            }
            //Set method for card value
            set
            {
                //Validation for card value being between 1 and 13
                if (value >= 1 && value <= 13)
                {
                    this.value = value;
                }
                //If value outside of that range a value out of range exception is thrown
                else
                {
                    throw new ArgumentOutOfRangeException("value out of range");
                }
            }
        }

        public int Suit
        {
            //Get method for card suit
            get
            {
                return suit;
            }
            //Set method for card suit
            set
            {
                //Validation for card suit being between 1 and 4
                if (value >= 1 && value <= 4)
                {
                    this.suit = value;
                }
                //If value outside of that range a value out of range exception is thrown
                else
                {
                    throw new ArgumentOutOfRangeException("suit out of range");
                }
            }
        }
    }
}
