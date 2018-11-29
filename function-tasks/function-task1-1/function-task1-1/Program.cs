using System;

namespace function_task1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma muuntaa syötetyn numeron yhtä moneksi tähdeksi. ");

            int n;
            while(true)
            {
                Console.Write("Syötä tähtien lukumäärä: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Nolla ei ole sallittu luku.");
                }
                else
                {
                    break;
                }
            }
            string asterisks = getNAsterisks(n);
            Console.WriteLine(asterisks);
            Console.ReadKey();
            
        }

        /// <summary>
        /// Ohjelma palauttaa merkkijonon.
        /// Ohjelmalle välitetään tulostettavien tähtien määrä
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static string getNAsterisks(int intN)
        {
           string result = string.Empty;
            for (int i = 0; i < intN; i++)
            {
                result += '*';
            }
            return result;
        }
    }
}
