using System;

namespace LoopTask3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N ensimmäistä numeroa yhteen. ");
            int X = 0;
            int i = 1;
            int sum = 0;

            do
            {
                Console.Write("Syötä luku: ");
                X = int.Parse(Console.ReadLine());

                if (X <= 0)
                {
                    Console.WriteLine("Luvun tulee olla yli 0.");
                }
            } while (X <= 0);

            while (i<=X)
            {
                sum = sum + i;
                i = i + 1;
            }
            Console.WriteLine($"Tulos on {sum}. ");

        }
    }
}
