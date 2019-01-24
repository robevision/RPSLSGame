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
     
        string gamerNameOne;
        string gamerNameTwo;
        //
        // (SPAWNER default actions)
        public Human()
        {
        
        }
        // (CAN DO)
        public override string ChooseGesture()
        {
            Console.WriteLine("Select a hand gesture to be ready at will (Choices are 'Rock', 'Paper', 'Scissors', 'Lizard', 'Spock': ");
            string gesture = Console.ReadLine();
          if(gesture!= "Rock" || gesture!="Paper" || gesture != "Scissors" || gesture != "Lizard" || gesture != "Spock")
            {
                return ChooseGesture();
            }
            else
            {
                return gesture;
            }
        }
        public override string ChoosePlayerOneName()
        {
            Console.WriteLine("What name would you like the game to call you?");
            gamerNameOne = Console.ReadLine();
            return gamerNameOne;
        }
        public override string ChoosePlayerTwoName()
        {
            Console.WriteLine("Now player two.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("What name would you like the game to call you?");
            gamerNameTwo = Console.ReadLine();
            return gamerNameTwo;
        }
    }
}
