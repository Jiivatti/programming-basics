using System;

namespace Looptask4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo 13-rivisen vakioveikkauksen.");
            Random rnd = new Random();

            for (int i = 1; i < 14; i++)
            {
                double muuttuja = rnd.NextDouble();
                if (muuttuja < 0.4)
                    Console.WriteLine($"{i}\t. 1");
                else if (muuttuja > 0.6)
                    Console.WriteLine($"{i}\t. X");
                else
                    Console.WriteLine($"{i}\t. 2");

            }
        }
    }
}
