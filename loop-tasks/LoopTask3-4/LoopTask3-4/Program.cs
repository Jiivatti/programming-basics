using System;

namespace LoopTask3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N ensimmäistä numeroa yhteen. ");
            int X = 0;
            int i = 0;
            int sum = 0;

            Console.Write("Syötä luku: ");
            X = int.Parse(Console.ReadLine());

            if (X >= 0)
                while (i <= X)
                {
                    sum = sum + 1;
                    i = i + 1;
                }
            else
                while (i <= X)
                {
                    sum = sum + 1;
                    i = i - 1;
                }

            Console.WriteLine($"Tulos on {sum}");
        }
    }
}
