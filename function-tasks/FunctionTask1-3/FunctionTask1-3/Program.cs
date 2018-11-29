using System;

namespace FunctionTask1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro(out int input);
            PrintData(inputChecker(input));
        }

        static void Intro(out int input)
        {
            Console.Write("Syötä numero väliltä 1-99: ");
            input = int.Parse(Console.ReadLine());
        }

        static string inputChecker(int a)
        {
            string result = "";
            if (a <= 0 || a >= 100)
            {
                Console.WriteLine("Virheellinen syöte! Numero väliltä 1-99. ");
            }
            else
                result = $"Luku {a} on hyväksyttyvä tulos. ";

            return result;

        }

        static void PrintData(string data)
        {
            Console.WriteLine(data);
        }
    }
}
