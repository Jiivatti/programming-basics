using System;

namespace LoopTask4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa 20 satunnaista lukua väliltä 1-50, ja tulostaa ne neljälle riville.");

            Random rnd = new Random();

            int rnd1 = rnd.Next(50);
            int rnd2 = rnd.Next(50);
            int rnd3 = rnd.Next(50);
            int rnd4 = rnd.Next(50);
            int rnd5 = rnd.Next(50);
            int rnd6 = rnd.Next(50);
            int rnd7 = rnd.Next(50);
            int rnd8 = rnd.Next(50);
            int rnd9 = rnd.Next(50);
            int rnd10 = rnd.Next(50);
            int rnd11 = rnd.Next(50);
            int rnd12 = rnd.Next(50);
            int rnd13 = rnd.Next(50);
            int rnd14 = rnd.Next(50);
            int rnd15 = rnd.Next(50);
            int rnd16 = rnd.Next(50);
            int rnd17 = rnd.Next(50);
            int rnd18 = rnd.Next(50);
            int rnd19 = rnd.Next(50);
            int rnd20 = rnd.Next(50);

            Console.WriteLine($"Rivi 1: {rnd1}, {rnd2}, {rnd3}, {rnd4}, {rnd5}");
            Console.WriteLine($"Rivi 2: {rnd6}, {rnd7}, {rnd8}, {rnd9}, {rnd10}");
            Console.WriteLine($"Rivi 3: {rnd11}, {rnd12}, {rnd13}, {rnd14}, {rnd15}");
            Console.WriteLine($"Rivi 4: {rnd16}, {rnd17}, {rnd18}, {rnd19}, {rnd20}");
        }
    }
}
