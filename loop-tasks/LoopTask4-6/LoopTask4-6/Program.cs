using System;

namespace LoopTask4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma heittää noppaa 1000 kertaa, ja kertoo kuinka monta kertaa saatiin luku 6.");
            Random rnd = new Random();
            int randomRnd;
            int x = 0;

            for (int i = 1; i < 1001; i++)
            {



                do
                {
                    randomRnd = rnd.Next(7);
                } while (randomRnd == 0);

                if (randomRnd == 6)
                {
                    x++;
                }

                Console.WriteLine($"{i}.\t {randomRnd}");
            }
            Console.WriteLine($"Numero 6 heitettiin {x} kertaa. ");
        }
    }
}
