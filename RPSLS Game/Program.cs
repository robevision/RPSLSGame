﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.OfferGameRules();
            game.ChooseGameMode();
            game.StartGamePrompts();
            game.RunGame();
            
 
            
        }
    }
}
