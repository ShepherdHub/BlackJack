using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackEngine
{
    public class Card
    {
        public CardSuite Suite { get; private set; }
        public Card(int num)
        {
            setSuite(num);
        }

        private void setSuite(int num)
        {
            int suiteNum = num / 13;
            switch (suiteNum)
            {
                case 0:
                    Suite = CardSuite.CLUBS;
                    break;
                case 1:
                    Suite = CardSuite.DIAMONDS;
                    break;
                case 2:
                    Suite = CardSuite.HEARTS;
                    break;
                case 3:
                    Suite = CardSuite.SPADES;
                    break;
                //default:
                    //throw new InvalidCardException();
            }
        }

       // public class InvalidCardException : Exception { }
    }


}
