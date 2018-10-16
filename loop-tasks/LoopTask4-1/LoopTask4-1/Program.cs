using System;

namespace LoopTask4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kokonaislukuja, ja laskee niiden neliöjuuren.");

            int i = 0;
            Random rnd = new Random();
            int rndNumber;


            do
            {
                rndNumber = rnd.Next(2, 10);
                Console.WriteLine($"{i + 1}.\t" + 
                    $"{rndNumber}\t" + 
                    $"{Math.Sqrt(rndNumber)}");
                i++;
            } while (i < 10);

        }
    }
}
