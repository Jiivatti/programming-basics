using System;

namespace arraytask3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Console.WriteLine("Ohjelma tulostaa 10 arvottua lukua väliltä 0-20, ja lisää ylimääräisen nollan lukujen 0-9 eteen.\t");
            Console.ReadKey();
            Checker(array);
        }

        static void Checker(int[] arr)
        {
            Random rng = new Random();

            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = rng.Next(21);
                Console.WriteLine($"Rivi {i + 1}: {arr[i]:d2}");
            }
        }
    }
}
