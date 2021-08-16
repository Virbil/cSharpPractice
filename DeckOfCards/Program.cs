using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Player me = new Player("Bryce");
            // Console.WriteLine($"Welcome, {me.Name}");

            Deck newDeck = new Deck();
            newDeck.Shuffle();

            newDeck.Deal();

            Card newCard = me.Draw(newDeck);
            newCard.SayCard();

            newDeck.Deal();
            Card nextCard = me.Draw(newDeck);
            nextCard.SayCard();
        }
    }
}
