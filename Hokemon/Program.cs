using System;

namespace Hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of Hokemon!!!\n\n");
            Hokemon hoke1 = new Hokemon();

            hoke1.get_details();

            Hokemon hoke2 = new Hokemon();

            hoke2.get_details();

            Halor halor_hoke1 = new Halor();
            halor_hoke1.get_details();

            Hinstinct hinstinct_hoke1 = new Hinstinct();
            hinstinct_hoke1.get_details();

            Hystic hystic_hoke1 = new Hystic();
            hystic_hoke1.get_details();

            hoke1.about();
            halor_hoke1.about();
            hinstinct_hoke1.about();
            hystic_hoke1.about();

            battle_arena arena1 = new battle_arena();// creating the object of the first arena

            arena1.challenge_request(hoke1);//argument hoke1 passed into the first arena

            arena1.accept_battle(hoke1, hoke2);

            arena1.battle(hoke1, hoke2);
            
        }
    }
}
