namespace SLVP_Week5_CardgameWar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game g = new Game();
            g.ShowDeck();
        }
    }
}