using System;

namespace stringModPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma muuttaa käyttäjän syötteestä e-kirjaimet @-merkiksi.\n" +
                "Syötä tekstiä.\n");
            string userInput = Console.ReadLine();

            var rep = userInput.Replace("e", "@");


            Console.WriteLine(rep);
        }
    }
}
