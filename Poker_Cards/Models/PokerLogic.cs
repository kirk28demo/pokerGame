using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Poker_Cards.Models
{
    public class PokerLogic : Card
    {
        public enum Hand
        {
            Nothing,
            FourCards,
            FullHouse,
            ThreeCards,
            OnePair,
            TwoPairs
        }
        private Card[] cards;
        public PokerLogic()
        {
            cards = new Card[5];
        }
        public Card[] MyCards
        {
            get
            { return cards; }
            set
            {
                cards[0] = value[0];
                cards[1] = value[1];
                cards[2] = value[2];
                cards[3] = value[3];
                cards[4] = value[4];
            }
        }
        public Hand EvaluateCard()
        {
            if (FourCards())
                return Hand.FourCards;
            else if (FullHouse())
                return Hand.FullHouse;
            else if (TwoPairs())
                return Hand.TwoPairs;
            else if (OnePair())
                return Hand.OnePair;
            else if (ThreeCards())
                return Hand.ThreeCards;
            return Hand.Nothing;
        }
        private bool FourCards()
        {
            if (cards[0].CardRank == cards[1].CardRank && cards[0].CardRank == cards[2].CardRank && cards[0].CardRank == cards[3].CardRank)
            {
                return true;
            }
            else if (cards[1].CardRank == cards[2].CardRank && cards[1].CardRank == cards[3].CardRank && cards[1].CardRank == cards[4].CardRank)
            {
                return true;
            }
            return false;
        }
        private bool FullHouse()
        {
            if ((cards[0].CardRank == cards[1].CardRank && cards[0].CardRank == cards[2].CardRank && cards[3].CardRank == cards[4].CardRank) ||
            (cards[0].CardRank == cards[1].CardRank && cards[2].CardRank == cards[3].CardRank && cards[2].CardRank == cards[4].CardRank))
            {
                return true;
            }
            return false;
        }
        private bool ThreeCards()
        {
            if ((cards[0].CardRank == cards[1].CardRank && cards[0].CardRank == cards[2].CardRank) ||
            (cards[1].CardRank == cards[2].CardRank && cards[1].CardRank == cards[3].CardRank))
            {
                return true;
            }
            else if (cards[2].CardRank == cards[3].CardRank && cards[2].CardRank == cards[4].CardRank)
            {
                return true;
            }
            return false;
        }
        private bool TwoPairs()
        {
            if (cards[0].CardRank == cards[1].CardRank && cards[2].CardRank == cards[3].CardRank)
            {
                return true;
            }
            else if (cards[0].CardRank == cards[1].CardRank && cards[3].CardRank == cards[4].CardRank)
            {
                return true;
            }
            else if (cards[1].CardRank == cards[2].CardRank && cards[3].CardRank == cards[4].CardRank)
            {
                return true;
            }
            else if (cards[1].CardRank == cards[2].CardRank && cards[3].CardRank == cards[4].CardRank)
            {
                return true;
            }
            return false;
        }
        private bool OnePair()
        {
            for(int i = 0; i < MyCards.Length -1; i++)
            {
                for(int j = i + 1; j < MyCards.Length; j++)
                {
                    if (MyCards[i].CardRank == MyCards[j].CardRank)
                        return true;
                }
            }            
            return false;
        }
    }
}