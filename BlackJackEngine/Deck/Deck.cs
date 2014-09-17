using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackEngine
{
    public class Deck
    {
        private List<Card> CardsInDeck { get; set; }

        public Deck()
        {
            CardsInDeck = new List<Card>();
        }

        public int Count 
        {
            get { return CardsInDeck.Count; }
        } 
        public void shuffle()
        {
            Random rng = new Random();
            for(int i=0; i<this.Count;i++)
            {
                int randNum = rng.Next(i,Count);
                swap(i, randNum);
            }
        }

        public Card dealCard()
        {
            if (CardsInDeck.Count == 0) throw new EmptyDeckException();
            Card card = CardsInDeck[0];
            CardsInDeck.RemoveAt(0);
            return card;
        }

        private void swap(int a, int b)
        {
            Card temp = CardsInDeck[a];
            CardsInDeck[a] = CardsInDeck[b];
            CardsInDeck[b] = temp;
        }

        public void addCard(Card card)
        {
            CardsInDeck.Add(card);
        }
    }

    public class EmptyDeckException : Exception 
    {
        public EmptyDeckException() : base() { }
        public EmptyDeckException(string message) : base(message) { }
        public EmptyDeckException(string message, Exception inner) : base(message, inner) { }
    }

}
