using System;

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
                        Console.WriteLine("Input reference number: ");
                        string refNum = Console.ReadLine();
                        if (Checker(refNum) == false)
                        {
                            Console.WriteLine("The reference number is incorrect.");
                        }
                        else
                        {
                            Console.WriteLine("The reference number is correct!");
                        }
                        break;

                    case "W":
                        NCreator();
                        break;
                }
            } while (choice.ToUpper() != "F");


            string UInterface()
            {
                Console.WriteLine("[Q] -- Test a reference number");
                Console.WriteLine("[W] -- Create new a reference number");
                Console.WriteLine("[F] -- Close program");

                return Console.ReadLine();
            }
        }

        public static bool Checker(string refNum)
        {
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

        public static void NCreator()
        {
            Console.Write("Input a seed consisting of 3-19 numbers to generate from: ");
            string seed = Console.ReadLine();

            if (seed.Length > 19)
            {
                Console.WriteLine("Your input was too long.");
            }
            else if (seed.Length < 3)
            {
                Console.WriteLine("Your input was too short.");
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
            }
        }
    }
}
