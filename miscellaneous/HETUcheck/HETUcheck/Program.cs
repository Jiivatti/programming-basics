using System;

namespace hetuPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkistaa henkilöturvatunnuksen oikeellisuuden käyttäjän syötteestä.\n");
            hCheck();
        }

        public static void hCheck()
        {
            Console.Write("Syötä tarkistettava henkilöturvatunnus: ");
            string userI = Console.ReadLine();

            userI = userI.ToUpper();

            if (dCheck(userI))
            {
                string characters = "0123456789ABCDEFHJKLMNPRSTUVWXY";
                char conf = userI[userI.Length - 1];
                userI = userI.Remove(6, 1);
                userI = userI.Remove(9);
                int chk = int.Parse(userI);
                int hNumber = chk % 31;


                if (conf == characters[hNumber])
                {
                    Console.WriteLine("\nSyötetty henkilöturvatunnus on hyväksyttävä.\n");
                }
                else
                {
                    Console.WriteLine("\nSyötetty henkilöturvatunnus on virheellinen.\n");
                }

            }
            else
            {
                Console.WriteLine($"Virhe");
            }


        }

        public static bool dCheck(string userI)
        {
            int d = int.Parse(userI.Substring(0, 2));
            int m = int.Parse(userI.Substring(2, 2));
            int y = int.Parse(userI.Substring(4, 2));

            try
            {
                DateTime DT = new DateTime(y, m, d);
            }
            catch (Exception decline)
            {
                Console.WriteLine(decline.Message);
                return false;
            }
            return true;
        }

    }
}
