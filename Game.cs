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
        private Card[] deck;
        private int deckIndex;

        // Let's remove Result and integrate the properties in Game.cs!

        public Card Player1Card { get; private set; }
        public Card Player2Card { get; private set; }
        public string RoundWinner { get; private set; }
        public int Player1Score { get; private set; }
        public int Player2Score { get; private set; }

        public bool GameOver { get; private set; }

        public string GameWinner { get; private set; }


        static Random rand = new Random();

        public Game()
        {
        }

        public void FillDeck()
        {
            deck = new Card[52];
            deckIndex = 0;

            Player1Score = 0;
            Player2Score = 0;

            foreach (CardSuit cSuit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardValue cValue in Enum.GetValues(typeof(CardValue)))
                {
                    deck[deckIndex] = new Card(cValue, cSuit);
                    deckIndex++;
                }
            }
        }

        /**
        public void ShowDeck()
        {
            foreach (Card c in deck)
            {
                System.Diagnostics.Debug.WriteLine("Card is: " + c.Value + " of " + c.Suit);
            }
            
        }
        **/

        /**
        public void RunDeck()
        {
            for (int i = 0; i < 52; i++)
            {
                Card c = SelectCard();
                System.Diagnostics.Debug.WriteLine("Card number " + (i+1) + ": " + c.Value + " of " + c.Suit + " | Cards left: " + deck.Length);
            }
            
        }
        **/

        // RIMELIGT LOONKE!!! LAV EN LISTE VERSION OGSÅ!!! Eller måske en dictionary version med suits som keys??
        // AT TESTE LÅRTET!!!
        public Card SelectCard()
        {
            int index = rand.Next(0, deck.Length-1);
            Card c = deck[index];
            for (int i = index; i < deck.Length-1; i++)
            {
                deck[i] = deck[i + 1];
            }        
            Array.Resize(ref deck, deck.Length - 1);
            return c;
        }
        
        public Result PlayRound()
        {
            Player1Card = SelectCard();
            Player2Card = SelectCard();

            string result = "";

            if (Player1Card.Value > Player2Card.Value)
            {
                Player1Score += 2;
                result = "Player1";
                //return new Result("Player1", false);
            }
            else if (Player1Card.Value < Player2Card.Value)
            {
                Player2Score += 2;
                result = "Player2";
                //return new Result("Player2", false);
            }
            else
            {
                Player1Score++;
                Player2Score++;
                result = "Draw";
                //return new Result("Draw", false);
            }

            if (deck.Length != 0)
            {
                return new Result(result, false);
            }
            else
            {
                if (Player1Score > Player2Score)
                {
                    return new Result(result, true, "Player1");
                }
                else if (Player1Score < Player2Score)
                {
                    return new Result(result, true, "Player2");
                }
                else
                {
                    return new Result(result, true, "Draw");
                }
            }
        }

    }
}
