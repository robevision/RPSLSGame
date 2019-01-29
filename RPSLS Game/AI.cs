using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Game
{
    class AI : Player
    {
        // (HAS A)
        string playerName;
        // (SPAWNER)
        public AI(string playerName)
        {
        score = 0;
        
                

        }
        // (CAN DO)
        public override void ChooseGesture()
        {
        
            gestureDecision = gestures[new Random().Next(0, 5)];
            System.Threading.Thread.Sleep(1000);
        }
        public override void PlayerScore()
        {

        }
    }
    
}
