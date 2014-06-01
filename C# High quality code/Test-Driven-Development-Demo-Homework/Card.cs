using System;

namespace Poker
{
    public class Card : ICard
    {
        private CardFace face;
        private CardSuit suit;

        public CardFace Face 
        {
            get { return this.face; }
            private set
            {
                this.face = value;
            }
        }

        public CardSuit Suit 
        {
            get { return this.suit; }
            private set
            {
                this.suit = value;
            }
        }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            string output = string.Format("{0} of {1}", this.Face, this.Suit);
            return output;
        }
    }
}
