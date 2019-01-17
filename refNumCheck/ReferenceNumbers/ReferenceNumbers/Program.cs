using System;
using System.IO;

namespace ReferenceNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            

            do
            {
                choice = UInterface();

                switch (choice.ToUpper())
                {
                    case "Q":
                        Console.Write("Input reference number: ");
                        string refNum = Console.ReadLine();
                        if (Checker(refNum) == false)
                        {
                            Console.WriteLine("\nThe reference number is incorrect.\n");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nThe reference number is correct!\n");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case "W":
                        SCreator();
                        break;

                    case "E":
                        MCreator();
                        break;
                        
                }
            } while (choice.ToUpper() != "F");


            string UInterface() // Switch case-rakenteen kanssa toimiva käyttöliittymä
            {
                Console.WriteLine("[Q] -- Test a reference number");
                Console.WriteLine("[W] -- Create a new reference number");
                Console.WriteLine("[E] -- Generate multiple references and save to file");
                Console.WriteLine("[F] -- Close program\n");

                return Console.ReadLine();
            } 
        }

        public static bool Checker(string refNum) // Funktio tarkistaa parametrinä välitetyn viitenumeron tarkisteen oikeellisuuden, ja palauttaa
        {                                         // boolean-arvon sen perusteella.
            if (refNum.Length < 3)
            {
                Console.WriteLine("Your input was too short.");
                return false;
            }
            else if (refNum.Length > 19)
            {
                Console.WriteLine("Your input was too long.");
                return false;
            }
            else if (refNum[0] == '0' || refNum[0] < '0')
            {
                Console.WriteLine("The number may not begin with 0 or less.");
                return false;
            }

            else
            {
                int sum = 0;
                int[] multiply = new int[] { 7, 3, 1 };
                int[] refArr = new int[refNum.Length];

                for (int i = 0; i < refNum.Length; i++)
                {
                    refArr[i] = int.Parse(refNum[i].ToString());
                }

                for (int i = 0; i < refArr.Length - 1; i++)
                {
                    sum += refArr[refArr.Length - 2 - i] * multiply[i % 3];
                }

                int checkSum = 10 - (sum % 10);

                if (checkSum == 10)
                {
                    checkSum = 0;
                }
                if (refArr[refArr.Length - 1] == checkSum)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static void SCreator() // Funktio luo tarkistenumeron käyttäjän syöttämään viitenumeron alkuosaan.
        {
            Console.Write("Input a seed consisting of 3-19 numbers to generate from: ");
            string seed = Console.ReadLine();

            if (seed.Length > 19)
            {
                Console.WriteLine("Your input was too long.");
                Console.ReadKey();
                Console.Clear();
            }
            else if (seed.Length < 3)
            {
                Console.WriteLine("Your input was too short.");
                Console.ReadKey();
                Console.Clear();
            }
            else if (seed[0] == '0' || seed[0] < '0')
            {
                Console.WriteLine("The number may not begin with 0 or less.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                int[] multiply = new int[] { 7, 3, 1 };
                int[] refArr = new int[seed.Length];
                int sum = 0;

                for (int i = 0; i < seed.Length; i++)
                {
                    refArr[i] = int.Parse(seed[i].ToString());
                }

                for (int i = 0; i < refArr.Length; i++)
                {
                    sum += refArr[refArr.Length - 1 - i] * multiply[i % 3];
                }

                int checkSum = 10 - (sum % 10);
                if (checkSum == 10)
                {
                    checkSum = 0;
                }

                string newNumb = seed + checkSum;

                for (int i = 1; i < newNumb.Length; i++)
                {
                    if (i % 5 == 0)
                    {
                        newNumb = newNumb.Insert(i, " ");
                    }
                }

                Console.WriteLine($"Your new reference number is: {newNumb}");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void MCreator() // Funktio generoi käyttäjän haluaman määrän uusia viitenumeroita, ja tallentaa ne tiedostoon referencenumbers.txt
        {
            string path = @"c:\temp\referencenumbers.txt";
            
            Console.Write("\nInput a seed consisting of 3-19 numbers to generate from: ");
            string seed = Console.ReadLine();
            Console.Write("Input the amount of reference numbers to generate: ");
            int n = Convert.ToInt32(Console.ReadLine());
            

            if (seed.Length > 19)
            {
                Console.WriteLine("Your input was too long.");
                Console.ReadKey();
                Console.Clear();
            }
            else if (seed.Length < 3)
            {
                Console.WriteLine("Your input was too short.");
                Console.ReadKey();
                Console.Clear();
            }
            else if (seed[0] == '0' || seed[0] < '0')
            {
                Console.WriteLine("The number may not begin with 0 or less.");
                Console.ReadKey();
                Console.Clear();
            }
            else if (n <= 0)
            {
                Console.WriteLine("Please input an acceptable amount of numbers to generate.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                for (int k = 0; k < n; k++)
                {
                    Random rng = new Random();
                    int g = rng.Next(11);
                    seed = seed + g;
                    int[] multiply = new int[] { 7, 3, 1 };
                    int[] refArr = new int[seed.Length];
                    int sum = 0;

                    for (int i = 0; i < seed.Length; i++)
                    {
                        refArr[i] = int.Parse(seed[i].ToString());
                    }

                    for (int i = 0; i < refArr.Length; i++)
                    {
                        sum += refArr[refArr.Length - 1 - i] * multiply[i % 3];
                    }

                    int checkSum = 10 - (sum % 10);
                    if (checkSum == 10)
                    {
                        checkSum = 0;
                    }

                    string newNumb = seed + checkSum;

                    for (int i = 1; i < newNumb.Length; i++)
                    {
                        if (i % 5 == 0)
                        {
                            newNumb = newNumb.Insert(i, " ");
                        }
                    }

                    Console.WriteLine($"Reference number {k + 1}: {newNumb}");


                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine($"Reference number {k + 1}: {newNumb}");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
