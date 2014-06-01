using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
namespace PokerTests
{
    /*Basically there's no "all caeses here, since we can't put anything else but suit in card suite 
     or face in card face. We can create all cards, but it's pointless.*/
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestCardToString()
        {
            Card card = new Card(CardFace.Two, CardSuit.Clubs);
            Assert.IsNotNull(card);
            Assert.AreEqual("Two of Clubs", card.ToString());
        }

        [TestMethod]
        public void TestCardProperties()
        {
            Card someCard = new Card(CardFace.Two, CardSuit.Clubs);
            Assert.IsNotNull(someCard);
            Assert.AreEqual("Two", someCard.Face.ToString());
            Assert.AreEqual("Clubs", someCard.Suit.ToString());
        }

        
    }
}
