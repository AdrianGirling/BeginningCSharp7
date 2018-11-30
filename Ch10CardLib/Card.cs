using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10CardLib
{
    public class Card {
        private readonly Rank rank;
        private readonly Suit suit;

        public Card(Suit newSuit, Rank newRank) {
            // non-default public constructor - to force the use of a specific constructor
            rank = newRank;
            suit = newSuit;
        }

        private Card() {
            // private default constructor
        }

        public override string ToString() {
            return "The " + rank + " of " + suit + "s";
        }
    }
}
