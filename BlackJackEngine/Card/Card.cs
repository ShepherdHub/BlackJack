using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackEngine
{
    public class Card
    {
        // Is this a type?  CardSuit perhaps?
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

        public override string ToString()
        {
            return String.Format("{0} of {1}",Rank, Suite);
        }

        public override bool Equals(object obj)
        {
            if(obj is Card)
            {
                return isCardEqual((Card)obj);
            }
            return false;
        }

        private bool isCardEqual(Card card)
        {
            if (isSameRankAndSuite(card))
            {
                return true;
            }
            return false;
        }

        private bool isSameRankAndSuite(Card card)
        {
            return (this.Rank == card.Rank && this.Suite == card.Suite);
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
    public class InvalidCardException : Exception 
    {
        public InvalidCardException() : base() { }
        public InvalidCardException(string message) : base(message) { }
        public InvalidCardException(string message, Exception inner) : base(message, inner) { }
    }


}
