using System;

namespace IF4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää kolmen syötetyn luvun korkeusjärjestyksen.");

            Console.Write("Syötä ensimmäinen luku: ");
            string userInput = Console.ReadLine();
            int numberA = int.Parse(userInput);
            Console.Write("Syötä toinen luku: ");
            userInput = Console.ReadLine();
            int numberB = int.Parse(userInput);
            Console.Write("Syötä kolmas luku: ");
            userInput = Console.ReadLine();
            int numberC = int.Parse(userInput);

            if (numberA > numberB)
            {
                if (numberA > numberC)
                    Console.WriteLine($"Järjestys on {numberA} > {numberB} > {numberC}");
                else
                    Console.WriteLine($"Järjestys on {numberC} > {numberA} > {numberB}");
            }
            else if (numberB > numberC)
            {
                if (numberC > numberA)
                    Console.WriteLine($"Järjestys on {numberB} > {numberC} > {numberA}");
                else
                    Console.WriteLine($"Järjestys on {numberB} > {numberA} > {numberC}");
            }
            else if (numberC > numberA)
            {
                if (numberB > numberA)
                    Console.WriteLine($"Järjestys on {numberC} > {numberB} > {numberA}");
                else
                    Console.WriteLine($"Järjestys on {numberA} > {numberC} > {numberB}");
            }

        }
    }
}
