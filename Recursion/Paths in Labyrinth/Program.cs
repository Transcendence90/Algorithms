using System;
using System.Collections.Generic;
using System.Linq;

namespace Paths_in_Labyrinth
{
    class Program
    {
        static char[,] labyrinth;

        static List<char> path = new List<char>();

        static void ReadLab()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            labyrinth = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string currentLine = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    labyrinth[row, col] = currentLine[col];
                }
            }
        }

        private static void FindPaths(int row, int col, char direction)
        {
            if (!IsInside(row, col))
            {
                return;
            }

            path.Add(direction);

            if (IsExit(row, col))
            {
                PrintSolution();
            }
            else if (IsPassable(row, col))
            {
                labyrinth[row, col] = 'x';

                FindPaths(row + 1, col, 'D'); //Down
                FindPaths(row - 1, col, 'U'); //Up
                FindPaths(row, col + 1, 'R'); //Right
                FindPaths(row, col - 1, 'L'); //Left

                labyrinth[row, col] = '-';
            }

            path.RemoveAt(path.Count - 1);
        }

        private static bool IsPassable(int row, int col)
        {
            // already visited

            if (labyrinth[row, col] == 'x')
            {
                return false;
            }

            // wall
            if (labyrinth[row, col] == '*')
            {
                return false;
            }

            return true;
        }

        private static bool IsExit(int row, int col)
        {
            return labyrinth[row, col] == 'e';
        }

        private static void PrintSolution()
        {
            Console.WriteLine(string.Join(string.Empty, path.Skip(1)));
        }

        private static bool IsInside(int row, int col)
        {
            return row >= 0 && row < labyrinth.GetLength(0)
                && col >= 0 && col < labyrinth.GetLength(1);
        }

        static void Main(string[] args)
        {
            ReadLab();
            FindPaths(0, 0, 'S');
        }
    }
}

