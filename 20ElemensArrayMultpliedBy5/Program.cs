using System;

namespace _20ElemensArrayMultpliedBy5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];

            for(int i=0; i < array.Length; i++)
            {
                array[i] = i * 5;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Element[{0}] = {1}", i, array[i]);
            }
            Console.ReadKey();
        }
    }
}
