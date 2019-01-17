using System;

namespace ArrayTask1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] luvut;
            luvut = new int[100];
            double sums = 0;
            double average = 0;


            for (int i = 0; i < luvut.Length; i++)
            {
                luvut[i] = rnd.Next(51);
                sums += luvut[i];
                Console.WriteLine($"{i + 1}. {luvut[i]}");
                average = sums / luvut.Length;
            }

            Console.WriteLine($"Arvottujen lukujen keskiarvo on {average}. ");
        }
    }
}
