using System;

namespace IF_1
{
    class Program
    {
        static void Main(string[] args) //Kommentti :D
        {
            Console.WriteLine("Ohjelma selvittää, onko syötetty luku positiivinen, " +
                "negatiivinen vai nolla.");
            Console.Write("Syötä numero: ");
            string userInput = Console.ReadLine(); //"userInput" on osoitettu muuttujaksi
            int muuttuja = int.Parse(userInput); 
            if (muuttuja == 0)
                Console.WriteLine($"Numero {muuttuja} on nolla.");
            else if (muuttuja < 0)
                Console.WriteLine($"Numero {muuttuja} on negatiivinen.");
            else
                Console.WriteLine($"Numero {muuttuja} on positiivinen.");
        }
    }
}
