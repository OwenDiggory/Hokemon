using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class battle_arena
    {
        public battle_arena()// constructor method notice its the same name as the class
        {
            Console.WriteLine("\n\n----- Welcome to the Battle Arena!!!!! -----");
        }

        public void challenge_request(Hokemon contender)
        {
            Console.WriteLine("{0}: Say's 'I want to ballte... Anyone willing to challenge me!?!?'", contender.Name);
            
        }

        public void accept_battle(Hokemon contender1, Hokemon contender2)
        {
            Console.WriteLine(contender2.Name + ": 'I accept your challenge " + contender1.Name + "' ");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(contender1.Name + ": 'LETS GO!!!' ");

        }
    }
}
