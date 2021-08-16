// Give the Card a property "suit" which will hold the suit of the card (Clubs, Spades, Hearts, Diamonds).
// Give the Card a property "val" which will hold the numerical value of the card 1-13 as integers.

using System;

namespace DeckOfCards
{
    class Card
    {
        private string cardVal;
        private int value;

        private string suit;

        public static string[] Suits = new string[4] {"Spades", "Hearts", "Diamonds", "Clubs"};
        public Card(string s, int val)
        {
            switch(val)
            {
                case 11:
                    cardVal = "Jack";
                    break;
                case 12:
                    cardVal = "Queen";
                    break;
                case 13:
                    cardVal = "King";
                    break;
                case 1:
                    cardVal = "Ace";
                    break;
                default:
                    cardVal = val.ToString();
                    break;
            }
            suit = s;
            value = val;
        }

        public void SayCard()
        {
            Console.WriteLine($"The {cardVal} of {suit}");
        }        
    }
}