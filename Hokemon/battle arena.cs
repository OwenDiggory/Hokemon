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
            Console.WriteLine("{0}: Say's 'I want to battle... Anyone willing to challenge me!?!?'", contender.Name);
            
        }

        public void accept_battle(Hokemon contender1, Hokemon contender2)
        {
            Console.WriteLine(contender2.Name + ": 'I accept your challenge " + contender1.Name + "' ");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(contender1.Name + ": 'LETS GO!!!' ");

        }

        public void battle(Hokemon Attacker, Hokemon Defender)
        {
            Hokemon temp_hoke;
            int round = 0;

            while(Convert.ToInt32(Attacker.Health) >= 0 || Convert.ToInt32(Defender.Health) >= 0)
            {
                int attack_value = Attacker.attack_calculator();
                int defence_value = Defender.defence_calculator();

                round += 1;

                Console.WriteLine("\n\n-*-*-*-ROUND" + round + "-*-*-*-\n\n");

                for(int i = 0; i < 2; i++)
                {
                    Console.WriteLine("{0} : Attackes with value {1}",Attacker.Name, attack_value);
                    Console.WriteLine("{0} : Defends with value {1}",Defender.Name, defence_value);
                    Console.WriteLine("{0} : Health = {1}",Defender.Name,Defender.Health);

                    Defender.Health = (Defender.Health + defence_value) - attack_value;

                    Console.WriteLine("\n{0}: Current Health = {1} // Calc: {1} + {2} - {3}",Defender.Name,Defender.Health,defence_value,attack_value);

                    Console.WriteLine("\n\n**** SWITCHING SIDES ****\n**** Attacker now defender ****");

                    temp_hoke = Attacker;
                    Attacker = Defender;
                    Defender = temp_hoke;

                }
            }

            if (Attacker.Health > Defender.Health)
            {
                Console.WriteLine(Attacker.Name + " IS THE WINNER");
            }
            else
            {
                Console.WriteLine(Defender.Name +" IS THE WINNER");
            }

        }
    }
}
