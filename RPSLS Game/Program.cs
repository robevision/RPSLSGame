using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.OfferGameRules();
            game.ChooseGameMode();
            game.RunGame();
            //player 1 vs player 2
            //player 1 vs AI
            //Round
            //Console.WriteLine("Choose a gesture.");
            //Gesture
            //Decision
            //Console.WriteLine("You won the game!");
            //Console.WriteLine("You lost the game.Try Again!");
            //recursion


            //planning from lecture
            //1. Display Rules (GameRules class?)
            //2. Get Player Names
            //3. choose game mode
            //4. player(s) choose gesture
            //5. Compare gestures
            //6. Determine the winner
            // a. increment score
            //7. Display round winner
            //8. check if game winner
            // a. if not game winner, input from step 4
            // b. if game winner supply optical award
            //9. prompt for a play again

            //Object oriented paradigm
            //what are the classes we should define?
            //Classes: Game, Player, Human : Player (user input) method ->virtual void ChooseGesture() in here and in child classes, A.I. : Player (check out built in random task), 
            // member variables in Player Class (string gesture), (int score), (string name), 
            //member variables in Game Class: we need 2 players, Player(data type and class)=player1
            //methods in Game Class (GetPlayers())
        }
    }
}
