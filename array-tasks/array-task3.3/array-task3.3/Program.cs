using System;

namespace arrayTask3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int[] sumArray = new int[10];
            Random rng = new Random();
            int i = 0;

            for (i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rng.Next(1, 51);
                arr2[i] = rng.Next(1, 51);
            }

            for (i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < arr2[i])
                {
                    sumArray[i] = arr2[i];
                }
                else
                {
                    sumArray[i] = arr1[i];
                }
            }

            Console.WriteLine("Tämä ohjelma luo kaksi taulukkoa,\nja hakee niistä indeksikohtaisesti" +
                "\nsuurimmat arvot kolmanteen taulukkoon. \n");

            Console.WriteLine("  Taulukko 1  -    Taulukko 2   -   Suurempi luku:" +
                "\n--------------------------------------------------");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i}|    {arr1[i]:d2}        -       {arr2[i]:d2}        -       {sumArray[i]:d2}");
            }


        }
    }
}
