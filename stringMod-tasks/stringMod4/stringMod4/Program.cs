using System;

namespace stringModPractice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkistaa onko käyttäjän antama syöte palindromi.");
            Console.WriteLine("Syötä teksti: \n");
            string str = Console.ReadLine();

            Console.WriteLine(checkP(str));


            string checkP(string inputString)
            {

                int length = inputString.Length;
                for (int i = 0; i < length / 2; i++)
                {
                    if (inputString[i] != inputString[length - 1 - i])
                    {
                        return $"{inputString} ei ole palindromi.";
                    }
                }

                return $"{inputString} on palindromi!";

            }
        }
    }
}
