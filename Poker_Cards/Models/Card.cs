using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Poker_Cards.Models
{
    public class Card
    {
        public enum SUIT {
            H, D, S, C
        }
        public enum RANK
        {
            Two, Three, Four, Five, Six, Seven, Eight, Nine , Ten, Jack, Queen, King, Ace
        }

        public SUIT CardSuit { get; set; }
        public RANK CardRank { get; set; }

    }
}