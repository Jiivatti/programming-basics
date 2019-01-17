using System;

namespace stringModPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tämä ohjelma selvittää käyttäjän antamasta syötteestä merkkien lukumäärän.\n" +
                "\nSyötä tekstiä: ");
            string asd = Console.ReadLine();
            var rep = asd.Length;
            Console.WriteLine($"\nMerkkien lukumäärä on {rep}.");
        }
    }
}
