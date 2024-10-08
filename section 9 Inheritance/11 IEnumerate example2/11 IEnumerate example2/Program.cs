﻿namespace _11_IEnumerate_example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>numberList = new List<int>() { 8,6,2};
            int[] numberArray = new int[] { 1, 7, 1, 3 };
            Console.WriteLine(" ");
            CollectionSum(numberList);

            Console.WriteLine(" ");

            CollectionSum(numberArray);
        }
        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            int sum = 0;

            foreach (int num in anyCollection)
            {
                sum += sum;
            }
            Console.WriteLine("Sum is {0}",sum);
        }
    }
}
