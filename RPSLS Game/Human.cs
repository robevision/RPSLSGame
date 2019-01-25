using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Game
{
    class Human : Player
    {
        // (HAS A)
        //int life;
        //int position;


        //
        // (SPAWNER default actions)
        public Human()
        {
            ChoosePlayerName();
        }
        // (CAN DO)
        public override void ChooseGesture()
        {
            Console.WriteLine("Select a hand gesture to be ready at will (Choices are 'Rock', 'Paper', 'Scissors', 'Lizard', 'Spock': ");
            string gesture = Console.ReadLine();
            if (gesture != "Rock" || gesture != "Paper" || gesture != "Scissors" || gesture != "Lizard" || gesture != "Spock")
            {
                ChooseGesture();
            }
        }
        public void ChoosePlayerName()
        {
            Console.WriteLine("What name would you like the game to call you?");
            playerName = Console.ReadLine();

        }
    }
}
