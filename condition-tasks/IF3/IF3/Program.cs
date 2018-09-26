using System;

namespace IF3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selittää onko luku pariton vai parillinen, positiivinen vai negatiivinen.");
            Console.Write("Syötä luku: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            if (number < 0)
            {if (number % 2 == 0)
                    Console.WriteLine($"Luku {number} on negatiivinen ja parillinen");
                else Console.WriteLine($"Luku {number} on negatiivinen ja pariton");
                        }
            if (number > 0)
            {
                if (number % 2 == 0)
                    Console.WriteLine($"Luku {number} on positiivinen ja parillinen");
                else Console.WriteLine($"Luku {number} on positiivinen ja pariton");
            }
        }
    }
}
