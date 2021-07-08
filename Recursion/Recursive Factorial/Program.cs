using System;

namespace Recursive_Factorial
{
    class Program
    {
        static long Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }

        protected static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(num));
        }
    }
}
