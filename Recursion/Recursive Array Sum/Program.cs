using System;
using System.Linq;

namespace Recursive_Array_Sum
{
    class Program
    {
        static int Sum(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                return 0;
            }

            return arr[index] + Sum(arr, index + 1);
        }

        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            var sum = Sum(numbers, 0);

            Console.WriteLine(sum);
        }
    }
}
