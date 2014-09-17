using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackJackEngineTester
{
    using BlackJackEngine;
    [TestClass]
    public class CardTest
    {
        private Card aceOfClubs = new Card(0);
        private Card aceOfDiamonds = new Card(13);
        private Card aceOfHearts = new Card(26);
        private Card aceOfSpades = new Card(39);

        [TestMethod]
        public void createAClub()
        {
            Assert.AreEqual(CardSuit.CLUBS, aceOfClubs.Suit);
        }

        [TestMethod]
        public void createADiamond()
        {
            Assert.AreEqual(CardSuit.DIAMONDS, aceOfDiamonds.Suit);
        }

        [TestMethod]
        public void createAHeart()
        {
            Assert.AreEqual(CardSuit.HEARTS, aceOfHearts.Suit);
        }

        [TestMethod]
        public void createASpade()
        {
            Assert.AreEqual(CardSuit.SPADES, aceOfSpades.Suit);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCardException))]
        public void cardValueAbove51ThrowsException()
        {
            Card card = new Card(52);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCardException))]
        public void cardValueBelow0ThrowsException()
        {
            Card card = new Card(-1);
        }

        [TestMethod]
        public void twoOfClubsHasRankOfTwo()
        {
            Card twoOfClubs = new Card(1);
            CardRank rank = twoOfClubs.Rank;
            Assert.AreEqual(CardRank.TWO, rank);
        }

        [TestMethod]
        public void cardStartsFaceUp()
        {
            Assert.IsTrue(aceOfClubs.isFaceUp());
        }

        [TestMethod]
        public void flipCardFaceDown()
        {
            aceOfClubs.flipCard();
            Assert.IsFalse(aceOfClubs.isFaceUp());
        }

        [TestMethod]
        public void cardsCanBeEqual()
        {
            Card a = new Card(5);
            Card b = new Card(5);
            Assert.IsTrue(a.Equals(b));
        }
    }
}
