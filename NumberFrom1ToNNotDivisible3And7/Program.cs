using System;

namespace NumberFrom1ToNNotDivisible3And7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            int num = 0;

            int.TryParse(Console.ReadLine(), out num);

            if (num > 0)
            {
                for (int i = 1; i <= num; i++)
                {
                    if ((i % (3 * 7) == 0))
                    {
                        Console.WriteLine(i + " is divisible");
                    }
                   
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You must write a number!");
                Console.ReadKey();
            }

        }
    }
}
