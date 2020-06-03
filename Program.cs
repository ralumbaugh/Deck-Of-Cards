using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Ryan = new Player("Ryan");
            Player Bry = new Player("Bry");
            Deck Gamedeck = new Deck();
            Gamedeck.Shuffle();
            Ryan.Draw(Gamedeck);
            Ryan.Discard(5);
            Ryan.Discard(0);
            Bry.Draw(Gamedeck);
            Gamedeck.NewDeck();
        }
    }
}
