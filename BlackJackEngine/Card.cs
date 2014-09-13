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
        public CardRank Rank { get; private set; }
        private bool FaceUp { get; set; }

        public Card(int num)
        {
            if (isOutOfBounds(num))
            {
                throw new InvalidCardException();
            }
            else
            {
                setSuite(num);
                setRank(num);
                FaceUp = true;
            }
            
        }

        public bool isFaceUp()
        {
            return FaceUp;
        }

        public void flipCard()
        {
            FaceUp = !FaceUp;
        }

        private bool isOutOfBounds(int num)
        {
            if (num < 0 || num > 51) return true;
            return false;
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
                default:
                    throw new InvalidCardException();
            }
        }

        private void setRank(int num)
        {
            Rank = (CardRank)(num % 13);
        }



        
    }
    public class InvalidCardException : Exception { }


}
