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
        string sheldonGesture;
        string gamerName;
        //SPAWNER
        public Sheldon()
        {

        }
        //CAN DO
        public virtual string ChooseGesture()
        {
            Console.WriteLine("Sheldon selects a gesture.");
            return "Spock";
        }
        public override string ChoosePlayerTwoName()
        {
            Console.WriteLine("Now the computer.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("What superior name would you like the game to call you?");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("S" + "    " + "H" + "    " + "E" + "    " + "L" + "    " + "D" + "    " + "O" + "    " + "N");
            System.Threading.Thread.Sleep(3000);
            Console.ReadLine();
            System.Threading.Thread.Sleep(3000);
            gamerName = "Sheldon";
            return gamerName;
        }
    }
}
