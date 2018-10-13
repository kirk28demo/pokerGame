using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Poker_Cards.Models
{
    public class Suit
    {
        public char SuitValue { get; set; }
        public List<string> suitList { get; set; }
    }
}