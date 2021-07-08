using System;

namespace Generating_0_1_Vectors
{
    class Program
    {
        static void Gen01(int index, int[] vector)
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Join("", vector));
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    vector[index] = i;
                    Gen01(index + 1, vector);
                }
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];

            Gen01(0, vector);
        }
    }
}
