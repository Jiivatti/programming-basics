using System;

namespace LoopTask4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma heittää mielikuvituksellista kolikkoa puolestasi, ja kertoo kruunien ja klaavojen määrän.");
            Console.Write("Montako heittoa saisi olla? ");
            string userInput = Console.ReadLine();
            int counter = int.Parse(userInput);
            int heads = 0;
            int tails = 0;
            Random rnd = new Random();

            for (int i = 0; i < counter; i++)
            {
                int rndNumber = rnd.Next(2);
                if (rndNumber == 0)
                    tails++;
                else
                    heads++;
            }
            Console.WriteLine($"Rahaa on heitetty {counter} kertaa. " +
                $"Klaavoja tuli {tails}, ja kruunia {heads} kertaa.");
        }
    }
}
