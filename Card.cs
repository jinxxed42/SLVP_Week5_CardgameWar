using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_Week5_CardgameWar
{
    internal class Card
    {
        public int Value { get; set; }
        public CardSuit Suit { get; set; }

        public Card(int value, CardSuit suit)
        {
            Value = value;
            Suit = suit;
        }
    }

    enum CardSuit
    {
        Club,
        Diamond,
        Heart,
        Spade
    }

    enum CardName
    {
        Ace,
        Jack,
        Queen,
        King
    }
}
