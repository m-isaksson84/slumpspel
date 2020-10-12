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
            int damage = generator.Next(10);
            int counterDamage = generator.Next(10);

            Console.WriteLine(hpPlayer1 + hpPlayer2 + "HP total");
            Console.WriteLine("FIGHT TO THE DEATH!");
            Console.ReadLine();

            while (playersAlive == true)
            {
                hpPlayer2 = hpPlayer2 - damage;
                Console.Clear();
                currentRound++;
                Console.WriteLine("Round " + currentRound + " Biden deals " + damage + " damage! Trump has " + hpPlayer2 + " health left!");
                Console.ReadLine();
                Console.Clear();

                hpPlayer1 = hpPlayer1 - counterDamage;
                Console.Clear();
                Console.WriteLine("Round " + currentRound + " Trump deals " + counterDamage + " damage! Biden has " + hpPlayer2 + " health left!");
                Console.ReadLine();
                Console.Clear();

                if (hpPlayer1 < 1)
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
                Console.ReadLine();
            }
        }
    }
}
