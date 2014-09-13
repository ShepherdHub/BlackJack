using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackEngine
{
    public class Player
    {
        public String Name { get; set; }
        public Deck Hand { get; set; }
        public int Score { get; private set; }
        public Player(String name="default name")
        {
            Name = name;
            Hand = new Deck();
        }

        public void increaseScore(int sc)
        {
            Score += sc;
        }

        public void addCardToHand(Card card)
        {
            Hand.addCard(card);
        }

        public int getHandSize()
        {
            return Hand.Count;
        }
    }
}
