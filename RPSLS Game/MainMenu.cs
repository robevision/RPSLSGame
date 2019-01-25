using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Game
{
    static class MainMenu
    {
        public static void StartFirstGesturePrompt()
        {
            Console.WriteLine("Players will now pick a gesture. Do not peek at each player's submission.");
            System.Threading.Thread.Sleep(1000);
        }
        public static void StartSecondGesturePrompt(Player player1, Player player2,int round)
        {
            Console.WriteLine("ROUND " + round);
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine(player1.playerName + " goes first.");
            player1.ChooseGesture();
            Console.WriteLine("Now " + player2.playerName);
            player2.ChooseGesture();
        }
        //public static void CallPlayerPrompt()
        //{
        //    playerName;
        //    playerOne.playerName = playerName;
            
        //    Console.WriteLine(playerName + "goes first.");
        //}
    }
}
