using System;
using System.Linq;
using System.Collections.Generic;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < hand.Cards.Count; i++)
                {
                    for (int k = i + 1; k < hand.Cards.Count; k++)
                    {
                        if (hand.Cards[i].Face == hand.Cards[k].Face &&
                        hand.Cards[i].Suit == hand.Cards[k].Suit)
                        {
                            throw new ArgumentException("A card deck can't have two equal cards.");
                        }
                    }
                }

                return true;
            }
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (this.IsValidHand(hand))
            {
                ICard checkCard = hand.Cards[0];
                int distinctCards = 0;
                for (int i = 1; i < hand.Cards.Count; i++)
                {
                    if (checkCard.Face != hand.Cards[i].Face)
                    {
                        distinctCards++;
                        if (distinctCards > 1)
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
            else
            {
                throw new ArgumentException("Invalid hand");
            }
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            
            if (this.IsValidHand(hand))
            {
                ICard comparisonCard = hand.Cards[0];
                for (int i = 1; i < hand.Cards.Count; i++)
                {
                    if (comparisonCard.Suit != hand.Cards[i].Suit)
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                throw new ArgumentException("Invalid hand.");
            }
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
