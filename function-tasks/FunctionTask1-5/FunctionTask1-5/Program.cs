using System;

namespace FunctionTask1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä kymmenen positiivista kokonaislukua. ");
            Console.WriteLine($"Suurin numero sarjassa oli {bigNumber(out int index)}. ");
        }

        static int bigNumber(out int index)
        {
            index = 0;
            int largestNumber = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}.");
                int userNumber = int.Parse(Console.ReadLine());
                if (userNumber < 0)
                {
                    Console.WriteLine("Virheellinen syöte! ");
                    i--;
                }

                if (userNumber > largestNumber)
                {
                    largestNumber = userNumber;
                    index = i + 1;
                }
            }
            return largestNumber;
        }
    }
}
