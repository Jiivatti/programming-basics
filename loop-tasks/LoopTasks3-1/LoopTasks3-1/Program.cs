using System;

namespace LoopTasks3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee annetun luvun kertoman. ");
            int X = 0;
            int i = 1;
            int fact = 1;
            do
            {
                Console.Write("Syötä luku: ");
                X = int.Parse(Console.ReadLine());

                if (X <= 0)
                {
                    Console.WriteLine($"Luku {X} on pienempi kuin 0. Ei kertomaa. ");
                }
            } while (X <= 0);

            while(i<=X)
            {
                fact = fact * i;   //fact=*i
                i = i + 1;         //i++
            }
            Console.WriteLine($"Luvun {X} kertoma on {fact}");
        }
    }
}
