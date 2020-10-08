using System;

namespace slump
{
    class Program
    {
        static void Main(string[] args)
        {
            int hpPlayer1 = 100;
            int hpPlayer2 = 100;
            bool playersAlive = true;

            Console.WriteLine(hpPlayer1 + hpPlayer2 + "HP total");
            Console.WriteLine("FIGHT TO THE DEATH!");
            Console.ReadLine();

            while (playersAlive == true)
            {


                if (hpPlayer1 < 1)
                {
                    playersAlive = false;
                    Console.WriteLine("Player 2 wins!");
                }

                Console.ReadLine();
            }
        }
    }
}
