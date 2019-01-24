using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Game
{
    class Gesture
    {
        //HAS A
        //(what are the member variables? The default values that exist throughout gestures)
        string name;
        //this could change to be added to their own class. Why would they need to be their own class?
        //SPAWNER
        public Gesture()
        {
         // (default input, what is necessary and has a default value?)
        }
        //CAN DO
      public bool BeLizard()
        {
            return false;
        }
      public bool BeSpock()
        {
            return false;
        }
      public bool BePaper()
        {
            return false;
        }
      public bool BeScissors()
        {
            return false;
        }
      public bool BeRock()
        {
            return false;
        }
      //(user info., prompts, additional characterizations to use or not use)
    }
}
