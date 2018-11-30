using System;

namespace Dumb_Murricans
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;

            do
            {
                choice = userInterface();

                switch (choice.ToUpper())
                {
                    case "Q":
                        Console.WriteLine("\nInsert the amount you wish to convert: ");
                        double FC = double.Parse(Console.ReadLine());
                        FC = FC - 32; FC = FC * 5;
                        FC = FC / 9; FC = Math.Round(FC, 1);
                        Console.WriteLine($"\nThe result is {FC}°C. \n");
                        break;

                    case "W":
                        Console.WriteLine("\nInsert the amount you wish to convert: ");
                        double CF = double.Parse(Console.ReadLine());
                        CF = CF * 9; CF = CF / 5;
                        CF = CF + 32; CF = Math.Round(CF, 1);
                        Console.WriteLine($"\nThe result is {CF}°F. \n");
                        break;

                    case "E":
                        Console.WriteLine("\nInsert the amount you wish to convert: ");
                        double KM = double.Parse(Console.ReadLine());
                        KM = KM * 0.62137;
                        KM = Math.Round(KM, 1);
                        Console.WriteLine($"\nThe result is {KM} miles. \n");
                        break;

                    case "R":
                        Console.WriteLine("\nInsert the amount you wish to convert: ");
                        double MK = double.Parse(Console.ReadLine());
                        MK = MK * 1.609344;
                        MK = Math.Round(MK, 1);
                        Console.WriteLine($"\nThe result is {MK}km. \n");
                        break;

                    case "T":
                        Console.WriteLine("\nInsert the amount you wish to convert: ");
                        double KL = double.Parse(Console.ReadLine());
                        KL = KL / 0.45359237;
                        KL = Math.Round(KL, 1);
                        Console.WriteLine($"\nThe result is {KL}lb. \n");
                        break;

                    case "Y":
                        Console.WriteLine("\nInsert the amount you wish to convert: ");
                        double LK = double.Parse(Console.ReadLine());
                        LK = LK * 0.45359237;
                        LK = Math.Round(LK, 1);
                        Console.WriteLine($"\nThe result is {LK}kg. \n");
                        break;
                }
            } while (choice.ToUpper() != "F");



            string userInterface()
            {
                Console.WriteLine("\n[Q] for °F to °C");
                Console.WriteLine("[W] for °C to °F");
                Console.WriteLine("[E] for kilometer to mile");
                Console.WriteLine("[R] for mile to kilometer");
                Console.WriteLine("[T] for kg to lb");
                Console.WriteLine("[Y] for lb to kg");
                Console.WriteLine("[F] to close the program.\n");
                Console.Write("Choose your fate: \n");
                return Console.ReadLine();
            }
        }
    }
}
