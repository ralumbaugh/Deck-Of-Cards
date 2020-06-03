using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        // Attributes
        public List<Card> Cards;

        // Constructor
        public Deck()
        {
            NewDeck();
        }
        // Methods
        public Card Deal()
        {
            Card DrawnCard = this.Cards[Cards.Count-1];
            this.Cards.Remove(DrawnCard);
            return DrawnCard;
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for(int i=0; i<this.Cards.Count; i++)
            {
                int RandomPosition = rand.Next(0,this.Cards.Count);
                Card CurrentCard = this.Cards[i];
                this.Cards[i] = this.Cards[RandomPosition];
                this.Cards[RandomPosition] = CurrentCard;
            }
        }
        public void NewDeck()
        {
            string[] Suits = {"Diamonds", "Hearts", "Clubs", "Spades"};
            string[] FaceValues = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            List<Card> MyDeck = new List<Card>();
            for(int i=0; i<Suits.Length; i++)
            {
                for(int j=0; j<FaceValues.Length; j++)
                {
                    MyDeck.Add(new Card($"{FaceValues[j]} of {Suits[i]}", Suits[i], j+1));
                }
            }
            this.Cards = MyDeck;
        }
    }
}
