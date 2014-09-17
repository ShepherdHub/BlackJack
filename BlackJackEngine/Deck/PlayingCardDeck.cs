using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackEngine
{
    public class PlayingCardDeck : Deck
    {
        public PlayingCardDeck():base()
        {
            for(int i = 0; i<52; i++)    //52 cards in a standard deck of playing cards
            {
                this.addCard(new Card(i));
            }
        }
    }
}
