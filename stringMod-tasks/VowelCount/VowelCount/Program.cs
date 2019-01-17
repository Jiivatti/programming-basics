using System;

namespace stringModPractice5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä laskee käyttäjän syötteestä vokaalien määrän.\n");
            Console.WriteLine("Syötä dataa:");
            string UI = Console.ReadLine();
            int k = UI.Length;
            int ctr = 0;

            Console.WriteLine(vchecker(UI));


            string vchecker(string inp)
            {

                for (int i = 0; i < k; i++)
                {
                    if (inp[i] == 'a' || inp[i] == 'e' || inp[i] == 'i' || inp[i] == 'o' || inp[i] == 'u'
                        || inp[i] == 'A' || inp[i] == 'E' || inp[i] == 'I' || inp[i] == 'O' || inp[i] == 'U'
                        || inp[i] == 'y' || inp[i] == 'Y' || inp[i] == 'ä' || inp[i] == 'Ä' || inp[i] == 'ö'
                        || inp[i] == 'Ö' || inp[i] == 'å' || inp[i] == 'Å')
                    {
                        ctr++;
                    }

                }

                return $"\nVokaaleiden lukumäärä: {ctr}";
            }
        }
    }
}
