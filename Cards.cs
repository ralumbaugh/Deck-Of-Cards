using System;
namespace DeckOfCards{
        public class Card
        {
            public string StringVal;
            public string Suit;
            public int Val;
            public Card(string StringVal, string Suit, int Val)
            {
                this.StringVal = StringVal;
                this.Suit = Suit;
                this.Val = Val;
            }
        }
}