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
        }

        public Card dealCard()
        {
            CardsInDeck.Add(new Card(1));
            return CardsInDeck[0];
        }

        public void addCard(Card card)
        {
            CardsInDeck.Add(card);
        }
    }
}
