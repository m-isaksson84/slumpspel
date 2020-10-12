using System;

namespace slump
{
    class Program
    {
        static void Main(string[] args)
        {
            int hpPlayer1 = 100;
            int hpPlayer2 = 100;

            int currentRound = 0;
            bool playersAlive = true;

            Random generator = new Random();

            Console.WriteLine("Trump and Biden have 200 HP in total");
            Console.WriteLine("FIGHT TO THE DEATH!");
            Console.ReadLine();

            while (playersAlive == true)
            {
                currentRound++;
                int damage = generator.Next(20);
                int counterDamage = generator.Next(20);
                hpPlayer2 = hpPlayer2 - damage;
                hpPlayer1 = hpPlayer1 - counterDamage;
                int healthPool = hpPlayer1 + hpPlayer2;

                Console.WriteLine("Round " + currentRound + " Biden deals " + damage + " damage! Trump has " + hpPlayer2 + " health left!");
                Console.WriteLine("Round " + currentRound + " Trump deals " + counterDamage + " damage! Biden has " + hpPlayer1 + " health left!");
                Console.ReadLine();


                if (healthPool < 1)
                {
                    playersAlive = false;
                    Console.WriteLine("Draw! Noone wins!");
                    Console.ReadLine();
                }
                else if (hpPlayer1 < 1)
                {
                    playersAlive = false;
                    Console.WriteLine("Trump wins!");
                    Console.ReadLine();
                }
                else if (hpPlayer2 < 1)
                {
                    playersAlive = false;
                    Console.WriteLine("Biden wins!");
                    Console.ReadLine();
                }
            }
        }
    }
}
