using System;

namespace LoopTask3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N:n ensimmäisen parittoman ja parillisen luvun summan.");
            int X = 0;
            int i = 1;
            int evenSum = 0;
            int oddSum = 0;

            Console.Write("Syötä luku: ");
            X = int.Parse(Console.ReadLine());

            while (i <= X)
            {
                if (i % 2 == 0)
                {
                    evenSum = evenSum + i;  //evenSum += i; toimii myös
                }
                else
                {
                    oddSum = oddSum + i;
                }
                i++;
            }
            Console.WriteLine($"Parillisten summa on {evenSum}, parittomien {oddSum}. ");
        }
    }
}
