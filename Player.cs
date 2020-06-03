using System;
using System.Collections.Generic;

namespace DeckOfCards{
        public class Player
        {
            // Attributes
            public string Name;
            public List<Card> Hand;
            // Constructor
            public Player(string Name)
            {
                this.Name = Name;
                this.Hand = new List<Card>();
            }
            // Methods
            public void Draw(Deck ThisDeck)
            {
                Card PlayerCard = ThisDeck.Deal();
                this.Hand.Add(PlayerCard);
            }

            public Card Discard(int index)
            {
                if(this.Hand.Count>index)
                {
                    Card DiscardedCard = this.Hand[index];
                    this.Hand.RemoveAt(index);
                    return DiscardedCard;
                }
                else
                {
                    Console.WriteLine($"There is no card at index position {index}");
                    return null;
                }
            }
        }
}