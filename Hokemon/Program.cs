﻿using System;

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

            battle_arena arena1 = new battle_arena();// creating the object of the first arena

            arena1.challenge_request(hoke1);//argument hoke1 passed into the first arena

            arena1.accept_battle(hoke1, hoke2);
        }
    }
}
