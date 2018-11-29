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
                        Console.WriteLine("Insert the amount you wish to convert: ");
                        double userInputFC = double.Parse(Console.ReadLine());
                        userInputFC = userInputFC - 32; userInputFC = userInputFC * 5;
                        userInputFC = userInputFC / 9;
                        Console.WriteLine($"The result is {userInputFC}.\n");
                        break;

                    case "W":
                        Console.WriteLine("Insert the amount you wish to convert: ");
                        double userInputCF = double.Parse(Console.ReadLine());
                        userInputCF = userInputCF * 9; userInputCF = userInputCF / 5;
                        userInputCF = userInputCF + 32;
                        Console.WriteLine($"The result is {userInputCF}.\n");
                        break;

                    case "E":
                        Console.WriteLine("Insert the amount you wish to convert: ");
                        double userInputMY = double.Parse(Console.ReadLine());
                        userInputMY = userInputMY / 0.9144;
                        Console.WriteLine($"The result is {userInputMY}\n");
                        break;

                    case "R":
                        Console.WriteLine("Insert the amount you wish to convert: ");
                        double userInputYM = double.Parse(Console.ReadLine());
                        userInputYM = userInputYM * 1.0936;
                        Console.WriteLine($"The result is {userInputYM}\n");
                        break;
                }
            } while (choice.ToUpper() != "F");



            string userInterface()
            {
                Console.WriteLine("[Q] for °F to °C");
                Console.WriteLine("[W] for °C to °F");
                Console.WriteLine("[E] for meter to yard");
                Console.WriteLine("[R] for yard to meter");
                Console.WriteLine("[F] to close the program.");
                Console.Write("Choose your fate: \n");
                return Console.ReadLine();
            }
        }
    }
}
