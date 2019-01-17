using System;

namespace stringModPractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input;

            int idx = -1;
            int ctr = -1;
            int tmp = 0;

            Console.WriteLine("Ohjelma selvittää kuinka monta kertaa käyttäjän syötteessä ilmenee kirjain L." +
                "\nSyötä teksti: ");
            Input = Console.ReadLine();

            while (tmp != -1)
            {
                tmp = Input.IndexOf("L", idx + 1);
                ctr += 1;
                idx = tmp;
            }


            Console.WriteLine($"\n{ctr} kertaa. ");


        }
    }
}
