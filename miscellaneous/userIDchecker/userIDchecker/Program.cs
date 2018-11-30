using System;

namespace userIDchecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, password;
            int ctr = 0, dd = 0;

            Console.WriteLine("\n----------------------------HALT--------------------------\n\n");
            Console.WriteLine("Time to see about that password.\n");

            do
            {
                Console.Write("Input username: \n");
                username = Console.ReadLine();
                Console.Write("Input password: \n");
                password = Console.ReadLine();

                if (username == "doctorevil" && password == "tfwminimeisdead")
                { 
                    dd = 1;
                    ctr = 3;
                }
                else
                {
                    dd = 0;
                    ctr++;
                    Console.WriteLine("\nWrong username or password. After 3 attempts, you will be DENIED.");
                    Console.WriteLine($"\nAttempts made at hacking this super computer: [{ctr}] \n");
                }
            } while (ctr != 3);

            if (dd == 0)
            {
                Console.WriteLine("\nDENIED\n");
            }
            else 
            if (dd == 1)
            {
                Console.WriteLine("\nLogin successful... This time..");
            }
        }

    }
}
