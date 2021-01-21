using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Hokemon
    {
        private string name;
        private int health;
        private int max_health;
        private int attack;
        private int speed;
        private int defence;

        public string Name
        {
            get { return name; }
            set { name = value;
            }
        }

        public int Health
        {
            get { return health; }
            set { health = value;
            }
        }

        public void provide_name()
        {
            Console.WriteLine("\nWhat is the name of your Hokemon? :");
            name = Console.ReadLine();
        }

        public void get_details()
        {
            Console.WriteLine("\n\n**********************\nName: {0}\nHealth: {1}/{2}\nAttack: {3}\nSpeed: {4}\nDefence: {5}", name, health, max_health, attack, speed, defence);
        }

        public int random_num_gen(int min, int max)
        {
            Random random = new Random();
            int random_value;
            random_value = random.Next(min, max);

            return random_value;
        }

        public Hokemon()
        {
            provide_name();
            max_health = 100;
            health = random_num_gen(10, max_health);
            attack = random_num_gen(10, 100);
            speed = random_num_gen(10, 100);
            defence = random_num_gen(10, 100);

        }

        public void about()
        {
            Console.WriteLine("\nIm am a mystical species known as Hokemon");
        }

        public int attack_calculator()
        {
            int attack_value;
            attack_value = (attack + speed) * random_num_gen(0,2);

            return attack_value;
        }

        public int defence_calculator()
        {
            int defence_value;
            defence_value = (defence + speed) * random_num_gen(0, 2);

            return defence_value;
        }
    }
}
