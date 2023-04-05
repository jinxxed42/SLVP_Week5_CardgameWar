﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_Week5_CardgameWar
{
    internal class Player
    {
        public int Score { get; set; }

        // Gemmer 26 kort per spiller i deres eget private deck. Det er smartere end at trække fra et kæmpe deck?? Ellers skal vi bare køre 26 runder?
        public List<Card> CardDeck { get; private set; }


    }
}