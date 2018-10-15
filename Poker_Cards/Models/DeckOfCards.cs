using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace Poker_Cards.Models
{
    public class DeckOfCards : Card
    {
        const int numberOfCards = 52;
        private Card[] deckCards;

        public Card[] GetDeck
        {
            get
            { return deckCards; }
        }

        public DeckOfCards()
        {
            deckCards = new Card[numberOfCards];
        }

        public void SetupCard()
        {
            int i = 0;
            foreach (SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach (RANK r in Enum.GetValues(typeof(RANK)))
                {
                    deckCards[i] = new Card { CardSuit = s, CardRank = r };
                    i++;
                }
            }
            ShuffleCard();
        }

        public void ShuffleCard()
        {
            Random rand = new Random();
            Card temp;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < numberOfCards; j++)
                {
                    int indexTemp = rand.Next(13);
                    temp = deckCards[j];
                    deckCards[j] = deckCards[indexTemp];
                    deckCards[indexTemp] = temp;
                }
            }
        }
    }
}