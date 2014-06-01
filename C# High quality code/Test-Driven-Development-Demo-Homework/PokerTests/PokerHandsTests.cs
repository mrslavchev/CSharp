using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Poker;

namespace PokerTests
{
    [TestClass]
    public class PokerHandsTests
    {
        #region IsValidHandTests
        [TestMethod]
        public void TestIsValidHand()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.IsTrue(checker.IsValidHand(hand));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidHand()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Hearts), // set two same cards on purpose.
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.IsTrue(checker.IsValidHand(hand));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidHandFiveSameCards()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.IsTrue(checker.IsValidHand(hand));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidHandSameCardsInEnds()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades), // set two same cards on purpose.
                new Card(CardFace.Ace, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.IsTrue(checker.IsValidHand(hand));
        }

        [TestMethod]
        public void TestInvalidHandCardsCount()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades), 
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.IsFalse(checker.IsValidHand(hand));
        }
        #endregion

        #region IsFlushTests
        [TestMethod]
        public void TestIsFlush()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs), 
                new Card(CardFace.Seven, CardSuit.Clubs)
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.IsTrue(checker.IsFlush(hand));
        }

        [TestMethod]
        public void TestIsNotFlush()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs), 
                new Card(CardFace.Seven, CardSuit.Clubs)
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.IsFalse(checker.IsFlush(hand));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFlushInvalidCount()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs), 
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.IsFalse(checker.IsFlush(hand));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRepeteadCard()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs), 
                new Card(CardFace.Ace, CardSuit.Clubs)
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.IsTrue(checker.IsFlush(hand));
        }
        #endregion

        #region IsFourOfaKindTests
        [TestMethod]
        public void TestIsFourOfaKind()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades), 
                new Card(CardFace.Seven, CardSuit.Clubs)
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void TestIsFourOfaKindMixedCards()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades)
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void TestIsNotFourOfaKind()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades), 
                new Card(CardFace.Seven, CardSuit.Clubs)
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIsFourOfaKindRepeatingCard()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades), 
                new Card(CardFace.Ace, CardSuit.Hearts)
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIsFourOfaKindInvalidCount()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades), 
                new Card(CardFace.Ace, CardSuit.Hearts)
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }
        #endregion
    }
}
