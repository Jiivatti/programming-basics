using System;

namespace FunctionTask1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro(out int x, out int y);
            PrintData(SmallerInput(x, y));
        }

        static void Intro(out int input1, out int input2)
        {
            Console.WriteLine("Ohjelma vertailee kahta lukua ja selvittää niiden suuruusjärjestyksen.");
            Console.Write("Syötä ensimmäinen luku: ");
            input1 = int.Parse(Console.ReadLine());
            Console.Write("Syötä toinen luku: ");
            input2 = int.Parse(Console.ReadLine());
        }

        static string SmallerInput(int a, int b)
        {
            if (a == b)
                return $"Luku {a} on yhtä suuri kuin luku {b}. ";
            else if (a > b)
                return $"Luku {a} on suurempi kuin luku {b}. ";
            else
                return $"Luku {b} on suurempi kuin luku {a}. ";
        }

        static string SmallerInput2(int a, int b)
        {
            string result = "";

            if (a == b)
                result = $"Luku {a} on yhtä suuri kuin luku {b}. ";
            else if (a > b)
                result = $"Luku {a} on suurempi kuin luku {b}. ";
            else
                result = $"Luku {b} on suurempi kuin luku {a}. ";

            return result;
        }

        static void PrintData(string data)
        {
            Console.WriteLine(data);
        }
    }
}
