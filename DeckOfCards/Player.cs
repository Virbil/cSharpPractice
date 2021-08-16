using System.Collections.Generic;

namespace DeckOfCards
{
    class Player
    {
        private string name;
        private List<Card> hand;
        public Player(string name)
        {
            this.name = name;
            hand = new List<Card>();
        }

        public string Name
        {
            get { return name; }
        }

        public Card Draw(Deck d)
        {
            Card topCard = d.Deal();
            hand.Add(topCard);
            return topCard;
        }

        public Card Discard(int idx)
        {
            Card topCard;
            if(idx < hand.Count)
            {
                topCard = hand[idx];
                hand.RemoveAt(idx);
                return topCard;
            }
            else { return null; }
        }
    }
}