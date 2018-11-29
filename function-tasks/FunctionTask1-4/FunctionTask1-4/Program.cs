using System;

namespace FunctionTask1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int retNumber = NumberFromRange(-100, 100);
            Console.WriteLine("Syötit sallitun numeron. Hieno homma!");
        }

        static int NumberFromRange(int lowerBound, int upperBound)
        {
            do
            {
                Console.Write($"Syötä numero väliltä {lowerBound} - {upperBound}: ");
                string userInput = Console.ReadLine();
                bool isNumber = int.TryParse(userInput, out int userNumber);

                if (isNumber && userNumber >= lowerBound && userNumber < upperBound)
                    return userNumber;

                else
                    Console.WriteLine("Virheellinen syöte..");

            } while (true);
        }
    }
}
