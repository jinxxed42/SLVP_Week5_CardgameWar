namespace SLVP_Week5_CardgameWar
{
    public partial class Form1 : Form
    {
        Game g = new Game();
        //int playerScore = 0;
        //int opponentScore = 0;

        public Form1()
        {
            InitializeComponent();        
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            if (btnPlay.Text == "Start game!") 
            {
                g.FillDeck();
                btnPlay.Text = "Play";
            }
            /**
            else
            {
                Card pCard = g.SelectCard();
                Card oCard = g.SelectCard();
                string result = "Player got card: " + pCard.Value + " of " + pCard.Suit + "\n";
                result += "Opponent got card: " + oCard.Value + " of " + oCard.Suit + "\n";
                if (pCard.Value > oCard.Value)
                {
                    result += "Winner of this round is player.";
                    playerScore += 2;
                }
                else if (pCard.Value < oCard.Value)
                {
                    result += "Winner of this round is opponent.";
                    opponentScore += 2;
                }
                else
                {
                    result += "This round is a draw.";
                    playerScore++;
                    opponentScore++;
                }
                tbPlayer1.Text = playerScore.ToString();
                tbPlayer2.Text = opponentScore.ToString();
                rtbGame.Text = result;
            }
            **/
            //g.ShowDeck();
            // SER UD TIL AT VIRKE MED ENUMS HYRH!!!!
            Result res = g.PlayRound();
            Update(res);
            /**
            Card c1 = g.SelectCard();
            Card c2 = g.SelectCard();
            if (c1.Value > c2.Value) 
            { 
                System.Diagnostics.Debug.WriteLine("c1 is " + c1.Value + " c2 is " + c2.Value + "  Highest card is c1");
            }
            else if (c1.Value < c2.Value)
            {
                System.Diagnostics.Debug.WriteLine("c1 is " + c1.Value + " c2 is " + c2.Value + "  Highest card is c2");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("c1 is " + c1.Value + " c2 is " + c2.Value + "  EQUAL");
            }
            **/
            //g.RunDeck();
        }


        public void Update()
        {
            rtbGame.Text = "Player 1 drew a " + g.Player1Card.Value.ToString() + " of " + g.Player1Card.Suit.ToString() + "\n";
            rtbGame.Text += "Player 2 drew a " + g.Player2Card.Value.ToString() + " of " + g.Player2Card.Suit.ToString() + "\n";


            if (g.RemainingCards == 0)
            {
                //Game over
            }
            else
            {
                tbPlayer1.Text = g.Player1Score.ToString();
                tbPlayer2.Text = g.Player2Score.ToString();
            }
        }
        
        // WHY INTERNAL SVIN....PUBLIC NO GOOD
        internal void Update(Result result)
        {
            rtbGame.Text = "Player 1 drew a " + g.Player1Card.Value.ToString() + " of " + g.Player1Card.Suit.ToString() + "\n";
            rtbGame.Text += "Player 2 drew a " + g.Player2Card.Value.ToString() + " of " + g.Player2Card.Suit.ToString() + "\n";


            if (result.GameOver)
            {
                btnPlay.Text = "Start game!";
                rtbGame.Text += "\n";
                if (result.GameWinner == "Draw")
                {
                    rtbGame.Text += "The game is over and it was a draw!";
                }
                else 
                {
                    rtbGame.Text += "The game is over and the winner is: " + result.GameWinner + "!";
                }
            }
            else
            {
                // DØDSE PÅ DET HER!
                tbPlayer1.Text = g.Player1Score.ToString();
                tbPlayer2.Text = g.Player2Score.ToString();
            }
        }


    }

}