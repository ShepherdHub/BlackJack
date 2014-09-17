using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackJackEngineTester
{
    using BlackJackEngine;
    [TestClass]
    public class GameTest
    {
        private Game game;

        [TestInitialize()]
        public void initializeGame()
        {
            game = new Game();
            game.start();
        }

        [TestMethod]
        public void createDealerName()
        {
            String actual = game.Dealer.Name;
            Assert.AreEqual("Dealer", actual);
        }

        [TestMethod]
        public void createPlayer1Name()
        {
            String actual = game.Player1.Name;
            Assert.AreEqual("Player One", actual);
        }

        
    }
}
