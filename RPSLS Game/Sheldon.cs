﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Game
{
    class Sheldon : Player
    {
        //HAS A
        
        //SPAWNER
        public Sheldon()
        {
            ChoosePlayerName();
            score = 0;
        }
        //CAN DO
        public override void ChooseGesture()
        {
            Console.WriteLine("Sheldon selects a gesture.");
            gestureDecision = "spock";
        }
        public override void PlayerScore()
        {
            
        }
        public void ChoosePlayerName()
        {
           playerName = "Sheldon";

        }

    }
}
