using System;
using System.Collections.Generic;
using System.Linq;

namespace SmallestAndLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers do you want to enter ?: ");
            int count = 0;
            int.TryParse(Console.ReadLine(), out count);
            List<int>numbersEntered = new List<int>();
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter a number: ");
                int num = 0;
                int.TryParse(Console.ReadLine(), out num);
                numbersEntered.Add(num);
            }
            Console.WriteLine("Smallest number: " + numbersEntered.Min());
            Console.WriteLine("Largest number: " + numbersEntered.Max());
            Console.ReadKey();
        }
    }
}
