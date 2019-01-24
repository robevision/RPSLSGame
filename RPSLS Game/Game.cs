using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Game
{
    class Game
    {
        //HAS
        Player playerOne;
        Player playerTwo;
        string gameMode;
        int PVP;
        private object playerOption;

        //SPAWNER
        public Game()
        {

        }
        //CAN DO
        //public string[] DefinePlayerOptionOne()
        //{
        //    string[] playerOptionOne = new string[4]
        //    {
        //        "frenemy", "Frenemy", "PVP", "pvp"
        //    };
        //    return playerOptionOne;
        //}
        public void ChooseGameMode()
        {
            string[] playerOptionOne = new string[4]
           {
                "frenemy", "Frenemy", "PVP", "pvp"
           };
            Console.WriteLine("Would you like to play with a frenemy or a computer player? (Type frenemy or computer player): ");
            string userInput = Console.ReadLine();
            //how do I create a condition using a string if I cant use math values with strings
            if (playerOptionOne.Contains(userInput))
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            //else if (userInput ==)
            //{

            //}

        }
        public void ChoosePVPGameMode()
        {

        }
       
                
    }

}

