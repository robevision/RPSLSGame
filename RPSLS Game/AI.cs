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
        string AIname;
        string aIGesture;
        // (SPAWNER)
        public AI()
        {
         
        }
        // (CAN DO)
        public override string ChooseGesture()
        {
            return aIGesture;
        }
        public override string ChoosePlayerOneName()
        {
            Console.WriteLine("A computer is player one.");
            System.Threading.Thread.Sleep(2000);
            string AINameOne = "AI-1";
            System.Threading.Thread.Sleep(2000);
            return AINameOne;
            //return base.ChoosePlayerOneName();
        }
        public override string ChoosePlayerTwoName()
        {
            Console.WriteLine("A computer is player two.");
            System.Threading.Thread.Sleep(2000);
            string AINameTwo = "AI-2";
            System.Threading.Thread.Sleep(2000);
            return AINameTwo;
        }
    }
    
}
