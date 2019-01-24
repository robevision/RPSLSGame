using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Game
{
    class Player
    {
        // (HAS A)
        int score;
        string gesture;
        string gamerName;

        // (SPAWNER)
        public Player()
        {
       
        }
        // (CAN DO)
        public virtual string ChooseGesture()
        {
            Console.WriteLine("Select a hand gesture to be ready at will (Choices are 'Rock', 'Paper', 'Scissors', 'Lizard', 'Spock': ");
            string gesture = Console.ReadLine();
            if (gesture != "Rock" || gesture != "Paper" || gesture != "Scissors" || gesture != "Lizard" || gesture != "Spock")
            {
                return ChooseGesture();
            }
            else
            {
                return gesture;
            }
        }
        public virtual string ChoosePlayerOneName()
        {
            Console.WriteLine("What name would you like the game to call you?");
            gamerName = Console.ReadLine();
            return gamerName;
        }
        public virtual string ChoosePlayerTwoName()
        {
            Console.WriteLine("A computer is player two.");
            System.Threading.Thread.Sleep(2000);
            string AINameTwo = "AI-2";
            System.Threading.Thread.Sleep(2000);
            return AINameTwo;
        }
    }
}
