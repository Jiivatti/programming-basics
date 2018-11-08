using System;

namespace Looptask4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo 13-rivisen vakioveikkauksen.");
            Random rnd = new Random();

            for (int i = 0; i < 13; i++)
            {
                double muuttuja = rnd.NextDouble();
                if (muuttuja < 0.4)
                    Console.WriteLine($"{i}. 1");
                else if (muuttuja == 0.4 - 0.6)
                    Console.WriteLine($"{i}. X");
                else
                    Console.WriteLine($"{i}. 2");

            }
        }
    }
}
