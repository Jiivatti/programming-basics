using System;

namespace FunctionTask1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stars();
            Console.WriteLine();
        }

        public static void Stars()
        {
            Console.WriteLine("Anna ohjelmalle luku: ");
            string userInput = Console.ReadLine();
            int number;
            int.TryParse(userInput, out number);

            if (number < 0)
            {
                Console.WriteLine("Syötä positiivinen kokonaisluku! ");
            }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
