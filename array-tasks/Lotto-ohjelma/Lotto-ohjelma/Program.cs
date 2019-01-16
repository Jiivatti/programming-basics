using System;

namespace Lotto-ohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            int tmp1, tmp2;
            int i = 0;
            Random rng = new Random();

            for (i = 0; i < array.Length; i++)
            {
                array[i] = rng.Next(1, 40);
            }

            for (i = 0; i < array.Length; i++)
            {
                for (tmp1 = i + 1; array.Length > tmp1; tmp1++)
                {
                    if (array[tmp1] < array[i])
                    {
                        tmp2 = array[i];
                        array[i] = array[tmp1];
                        array[tmp1] = tmp2;
                    }
                }
            }


            Console.WriteLine("Tämä ohjelma tulostaa 7 arvottua lottonumeroa korkeusjärjestyksessä.\n" +
                "----------------------------------\n");
            Console.ReadKey();

            for (i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine("\n");




        }
    }
}
