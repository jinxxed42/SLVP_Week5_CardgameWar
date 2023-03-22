using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_Week5_CardgameWar
{
    internal class Game
    {
        private Card[] deck = new Card[52];
        private int deckIndex = 0;

        private int playerOneScore = 0;
        private int playerTwoScore = 0;

        static Random rand = new Random();

        public Game()
        {
            FillDeck();
        }

        private void FillDeck()
        {
            for (int i = 1; i <= 13; i++)
            {
                Card cClub = new Card(i, CardSuit.Club);
                deck[deckIndex] = cClub;
                deckIndex++;
                Card cDiamond = new Card(i, CardSuit.Diamond);
                deck[deckIndex] = cDiamond;
                deckIndex++;
                Card cHeart = new Card(i, CardSuit.Heart);
                deck[deckIndex] = cHeart;
                deckIndex++;
                Card cSpade = new Card(i, CardSuit.Spade);
                deck[deckIndex] = cSpade;
                deckIndex++;
            }
        }


        public void ShowDeck()
        {
            foreach (Card c in deck)
            {
                System.Diagnostics.Debug.WriteLine("Card is: " + c.Value + " of " + c.Suit);
            }
            
        }
        

        // RIMELIGT LOONKE!!! LAV EN LISTE VERSION OGSÅ!!! Eller måske en dictionary version med suits som keys??
        // AT TESTE LÅRTET!!!
        private Card SelectCard()
        {
            int index = rand.Next(1, deck.Length);
            Card c = deck[index];
            for (int i = index; i < deck.Length; i++)
            {
                deck[i] = deck[i + 1];
            }        
            Array.Resize(ref deck, deck.Length - 1);
            return c;
        }
        

    }
}
