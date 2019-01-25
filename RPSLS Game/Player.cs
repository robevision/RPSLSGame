﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Game
{
    public abstract class Player
    {
        // (HAS A)
        public int score;
        public string [] gestures;
        public string playerName;
        public string gestureDecision;

        // (SPAWNER)
        public Player()
        {
          score = 0;
        }
        // (CAN DO)
        public abstract void ChooseGesture();
        public abstract void PlayerScore();
      
    }
}
