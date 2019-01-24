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
        private object playerOption;
        string[] playerOptionOne;
        string[] playerOptionTwo;
        string[] playerOptionThree;
        string[] playerOptionFour;

        //SPAWNER
        public Game()
        {
            playerOptionOne = new string[2]
            {
                "frenemy", "pvp"
            };
            playerOptionTwo = new string[8]
           {
                "ai", "personal computer", "computer player", "pc", "mac", "macintosh","p.c.", "a.i."
           };
            playerOptionThree = new string[1]
          {
                "simulation"
          };
            playerOptionFour = new string[3]
        {
                "big bang", "big bang theory", "sheldon"
        };
        }
        //CAN DO
        public void EvaluateGestureOne()
        {
        
        }
        public void EvaluateGestureTwo()
        {

        }
        public void ChooseGameMode()
        {
            Console.WriteLine("Would you like to play with a frenemy or a computer player? (Type frenemy or computer player): ");
            string userInput = Console.ReadLine();
            //how do I create a condition using a string if I cant use math values with strings
            if (playerOptionOne.Contains(userInput.ToLower()))
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            else if (playerOptionTwo.Contains(userInput.ToLower()))
            {
                playerOne = new Human();
                playerTwo = new AI();
            }
            else if (playerOptionThree.Contains(userInput.ToLower()))
            {
                playerOne = new AI();
                playerTwo = new AI();
            }
            else if (playerOptionFour.Contains(userInput.ToLower()))
            {
                playerOne = new Human();
                playerTwo = new Sheldon();
            }
            else
            {
                Console.WriteLine("You entered an invalid response.");
                ChooseGameMode();
            }

        }
        public void RunGame()
        {
            playerOne.ChoosePlayerOneName();
            playerTwo.ChoosePlayerTwoName();
            Console.WriteLine("Players will now pick a gesture. Do not peek at each player's submission.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Player One goes first.");
            playerOne.ChooseGesture();
            EvaluateGestureOne();
            Console.WriteLine("Now Player Two.");
            playerTwo.ChooseGesture();
            EvaluateGestureTwo();
        }
       public void OfferGameRules()
        {
            Console.WriteLine("Welcome to the 'Rock, Paper, Scissors, Lizard, Spock Game'");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Rules are simple.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Rock crushes Scissors");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Scissors cuts Paper");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Paper covers Rock");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Rock crushes Lizard");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Lizard poisons Spock");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Spock smashes Scissors");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Scissors decapitates Lizard");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Lizard eats Paper");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Paper disproves Spock");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Spock vaporizes Rock");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Rock crushes Scissors");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Got it?");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("After two consecutive round wins, the victory is yours.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Are you ready?");
            System.Threading.Thread.Sleep(3000);
        }
                
    }

}

