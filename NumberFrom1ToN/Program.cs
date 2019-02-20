using System;

namespace NumberFrom1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            int numberReaded = 0;

            int.TryParse(Console.ReadLine(), out numberReaded);

            if (numberReaded > 0)
            {
                for (int i = 1; i <= numberReaded; i++)
                {
                    Console.WriteLine(i);
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
