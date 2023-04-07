using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_Week5_CardgameWar
{
    internal class Player
    {
        public int Score { get; set; }

        // Saving 26 cards per player in their own private deck.
        public List<Card> CardDeck { get; private set; }

    }
}
