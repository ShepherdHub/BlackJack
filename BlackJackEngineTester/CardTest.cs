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
            Assert.AreEqual(CardSuite.CLUBS, aceOfClubs.Suite);
        }
        [TestMethod]
        public void createADiamond()
        {
            Assert.AreEqual(CardSuite.DIAMONDS, aceOfDiamonds.Suite);
        }
        [TestMethod]
        public void createAHeart()
        {
            Assert.AreEqual(CardSuite.HEARTS, aceOfHearts.Suite);
        }
        [TestMethod]
        public void createASpade()
        {
            Assert.AreEqual(CardSuite.SPADES, aceOfSpades.Suite);
        }
    }
}
