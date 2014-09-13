using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackEngine
{
    public class Game
    {
        public Player Dealer { get; set; }
        public Player Player1 { get; set; }
        public Deck Deck { get; set; }

        public void start()
        {
            Dealer = new Player("Dealer");
            Player1 = new Player("Player One");
            Deck = new PlayingCardDeck();
            
        }


    }
}
