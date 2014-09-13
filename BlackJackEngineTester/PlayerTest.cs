using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackJackEngineTester
{
    using BlackJackEngine;
    [TestClass]
    public class PlayerTest
    {
        private Player p;
        [TestInitialize()]
        public void createTestPlayer()
        {
            p = new Player();
        }
        [TestMethod]
        public void newPlayer1HandIsEmpty()
        {
            Assert.AreEqual(0, p.getHandSize());
        }

        [TestMethod]
        public void playerScoreStartsAtZero()
        {
            Assert.AreEqual(0, p.Score);
        }

        [TestMethod]
        public void increasePlayerScore()
        {
            p.increaseScore(5);
            Assert.AreEqual(5, p.Score);
        }

        [TestMethod]
        public void addCardToHand()
        {
            p.addCardToHand(new Card(1));
            Assert.AreEqual(1, p.getHandSize());

        }
    }
}
