namespace SLVP_Week5_CardgameWar
{
    public partial class Form1 : Form
    {
        Game g = new Game();

        public Form1()
        {
            InitializeComponent();
            //tlp1
            //tlp1.RowCount = 1;
            //tlp1.ColumnCount = 1;
            //Panel pnl1 = new Panel();
            //this.Controls.Add(pnl1);
            List<PlayerControl> playerControls = new List<PlayerControl>();
            
            foreach (Player p in g.players) 
            {
                PlayerControl playerControl = new PlayerControl(p);
                playerControls.Add(playerControl);
                //tlp1.Controls.Add(playerControl);
                pnl1.Controls.Add(playerControl);
            }
            //tlp1.Show();
            //pnl1.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            if (btnPlay.Text == "Start game!") 
            {
                g.FillDeck();
                btnPlay.Text = "Play";
            }

            Result res = g.PlayRound();
            Update(res);
        }

        /**
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
        **/
        
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
                    MessageBox.Show("The game is over and it was a draw!");
                }
                else 
                {
                    MessageBox.Show("The game is over and the winner is: " + result.GameWinner + "!");
                }
            }
            else
            {
                // D�DSE P� DET HER!
                tbPlayer1.Text = g.Player1Score.ToString();
                tbPlayer2.Text = g.Player2Score.ToString();
            }
        }
    }
}