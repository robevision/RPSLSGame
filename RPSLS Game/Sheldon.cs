using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Game
{
    class Sheldon : Player
    {
        //HAS A
        string playerName;
        //SPAWNER
        public Sheldon(string playerName)
        {

        }
        //CAN DO
        public override void ChooseGesture()
        {
            Console.WriteLine("Sheldon selects a gesture.");
            gestureDecision = "spock";
        }
    }
}
