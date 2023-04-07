using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_Week5_CardgameWar
{
    internal class Card
    {
        public CardValue Value { get; set; }
        public CardSuit Suit { get; set; }

        public Card(CardValue value, CardSuit suit)
        {
            Value = value;
            Suit = suit;
        }
    }

    enum CardSuit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    enum CardValue
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    /**
    enum CardName
    {
        Ace,
        Jack,
        Queen,
        King
    }
    **/
}
