using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackEngine
{
    public class Card
    {
        public CardSuit Suit { get; private set; }
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
                setSuit(num);
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
            return String.Format("{0} of {1}",Rank, Suit);
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
            if (isSameRankAndSuit(card))
            {
                return true;
            }
            return false;
        }

        private bool isSameRankAndSuit(Card card)
        {
            return (this.Rank == card.Rank && this.Suit == card.Suit);
        }

        private bool isOutOfBounds(int num)
        {
            if (num < 0 || num > 51) return true;
            return false;
        }

        private void setSuit(int num)
        {
            int suiteNum = num / 13;
            switch (suiteNum)
            {
                case 0:
                    Suit = CardSuit.CLUBS;
                    break;
                case 1:
                    Suit = CardSuit.DIAMONDS;
                    break;
                case 2:
                    Suit = CardSuit.HEARTS;
                    break;
                case 3:
                    Suit = CardSuit.SPADES;
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
