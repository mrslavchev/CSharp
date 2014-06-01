using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace PokerTests
{
    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void TestHand()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });

            Assert.IsNotNull(hand);
            Assert.AreEqual(5, hand.Cards.Count);
            Assert.AreEqual(typeof(Card), hand.Cards[0].GetType());
        }

        [TestMethod]
        public void TestHandToString()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });

            Assert.IsNotNull(hand);
            Assert.AreEqual("Ace of Clubs Ace of Diamonds King of Hearts King of Spades Seven of Diamonds ",
                hand.ToString());
        }
    }
}
