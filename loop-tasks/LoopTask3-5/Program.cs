using System;

namespace LoopTask3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N:n ensimmäisen parittoman ja parillisen luvun summan.");
            int X = 0;
            int i = 0;
            int evenSum = 0;
            int oddSum = 0;

            Console.Write("Syötä luku: ");
            X = int.Parse(Console.ReadLine());

            if (X > 0)
            {
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
            }            else

            {
                while (i >= X)
                {
                    if (i % 2 == 0)
                    {
                        evenSum = evenSum + i;
                    }
                    else
                    {
                        oddSum = oddSum + i;
                    }
                    i--;
                }
            }
            Console.WriteLine($"Parillisten tulos on {evenSum}, parittomien {oddSum}. ");
        }
    }
}
