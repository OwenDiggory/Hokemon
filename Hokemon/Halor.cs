using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Halor : Hokemon
    {
        private string team = "Halor";


        public void about() // POLYMORPHISM from the hokemon about method
        {
            Console.WriteLine("\nI am {0}, part of team {1}!! \n", Name, team);
        }
    }
}
