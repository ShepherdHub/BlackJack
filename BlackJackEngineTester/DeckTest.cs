using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackJackEngineTester
{
    using BlackJackEngine;
    [TestClass]
    public class DeckTest
    {
        Deck deck;
        [TestInitialize()]
        public void createPlayingCardDeck()
        {
            deck = new PlayingCardDeck();
        }
        [TestMethod]
        public void playingCardDeckHas52Cards()
        {
            Assert.AreEqual(deck.Count, 52);
        }
        [TestMethod]
        public void firstCardDealtIs0()
        {
            Card actual = deck.dealCard();
            Card expected = new Card(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void secondCardDealtIs1()
        {
            deck.dealCard();
            Card actual = deck.dealCard();
            Card expected = new Card(1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyDeckException))]
        public void dealingFromEmptyDeckThrowsException()
        {
            Deck emptyDeck = new Deck();
            emptyDeck.dealCard();
        }

        [TestMethod]
        public void unshuffledDeckIsOrdered()
        {
            Assert.IsFalse(isDeckShuffled(deck));
        }

        [TestMethod]
        public void shuffledDeckIsNotOrdered()
        {
            deck.shuffle();
            Assert.IsTrue(isDeckShuffled(deck));
        }

        private bool isDeckShuffled(Deck deck)
        {
            Deck unshuffled = new PlayingCardDeck();
            return !isSameDeck(deck, unshuffled);
        }

        private bool isSameDeck(Deck d1, Deck d2)
        {
            int size = d1.Count;
            int sameCardCount = 0;
            for(int i=0; i<size;i++)
            {
                Card card1 = d1.dealCard();
                Card card2 = d2.dealCard();
                if (card1.Equals(card2)) sameCardCount++;
            }
            if (sameCardCount == size) return true;
            return false;
        }
    }
}
