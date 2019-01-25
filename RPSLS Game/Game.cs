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
        string[] playerOptionOne;
        string[] playerOptionTwo;
        string[] playerOptionThree;
        string[] playerOptionFour;
        string gestureOptionOne;
        string gestureOptionTwo;
        int round;

        //SPAWNER
        public Game()
        {
            round = 0;
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
   
        public void ChooseGameMode()
        {
            Console.WriteLine("Would you like to play with a frenemy or a computer player? (Type frenemy or computer player): ");
            string userInput = Console.ReadLine();
            //how do I create a condition using a string if I cant use math values with strings
            if (playerOptionOne.Contains(userInput.ToLower()))
            {
                playerOne = new Human();
                Console.WriteLine("Now player two.");
                System.Threading.Thread.Sleep(2000);
                playerTwo = new Human();
            }
            else if (playerOptionTwo.Contains(userInput.ToLower()))
            {
                playerOne = new Human();
                playerTwo = new AI("AI-1");
            }
            else if (playerOptionThree.Contains(userInput.ToLower()))
            {
                playerOne = new AI("AI-1");
                Console.WriteLine("A computer is player one.");
                System.Threading.Thread.Sleep(2000);
                playerTwo = new AI("AI-2");
                Console.WriteLine("A computer is player two.");
                System.Threading.Thread.Sleep(2000);
            }
            else if (playerOptionFour.Contains(userInput.ToLower()))
            {
                playerOne = new Human();
                playerTwo = new Sheldon("Sheldon");
                Console.WriteLine("Now the computer.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("What superior name would you like the game to call you?");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("S" + "    " + "H" + "    " + "E" + "    " + "L" + "    " + "D" + "    " + "O" + "    " + "N");
                System.Threading.Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("You entered an invalid response.");
                ChooseGameMode();
            }

        }

        public void EvaluateGesture()
        {
           
            Console.WriteLine(gestureOptionOne);
            Console.WriteLine(gestureOptionTwo);
            System.Threading.Thread.Sleep(1000);
            do
            {
                Console.WriteLine("You both chose the same gesture. DRAW. Go again.");
                round++;
                System.Threading.Thread.Sleep(1000);
                MainMenu.StartSecondGesturePrompt(playerOne, playerTwo);
            }
            while (gestureOptionOne == gestureOptionTwo);
            if(gestureOptionOne == "rock" && gestureOptionTwo == "scissors" || gestureOptionTwo == "lizard")
            {

            }
            else if(gestureOptionOne == "spock" && gestureOptionTwo == "scissors" || gestureOptionTwo == "rock")
            {

            }
            else if(gestureOptionOne == "scissors" && gestureOptionTwo == "lizard" || gestureOptionTwo == "paper")
            {

            }
            else if(gestureOptionOne == "lizard" && gestureOptionTwo == "paper" || gestureOptionTwo == "spock")
            {

            }
            else if(gestureOptionOne == "paper" && gestureOptionTwo == "spock" || gestureOptionTwo == "rock")
            {

            }
        }
        public void RunGame()
        {
        MainMenu.StartFirstGesturePrompt();
        MainMenu.StartSecondGesturePrompt(playerOne, playerTwo);
        EvaluateGesture();
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

