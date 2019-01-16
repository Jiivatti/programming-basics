using System;

namespace arrayTask3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int[,] array = new int[10, 20];

            Console.WriteLine("Tämä ohjelma tulostaa kaksiulotteisen taulukon ja täyttää sen satunnaisilla numeroilla väliltä 1-100.\n");
            Console.WriteLine("[X - Y] = Arvo");
            Console.ReadKey();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    array[i, j] = rnd.Next(0, 101);
                    Console.WriteLine($"[{i} - {j}] = {array[i, j]:d2}");
                }
            }


        }
    }
}
