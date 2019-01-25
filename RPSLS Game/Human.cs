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
            gestures = new string[5]
            {
                "rock", "paper","scissors","lizard","spock"
            };
        }
        // (CAN DO)
        public override void ChooseGesture()
        {
            Console.WriteLine("Select a hand gesture to be ready at will (Choices are 'Rock', 'Paper', 'Scissors', 'Lizard', 'Spock': ");
            gestureDecision = Console.ReadLine().ToLower();
            if (!gestures.Contains(gestureDecision))
            {
                Console.WriteLine("You need to type one of the choices.");
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
