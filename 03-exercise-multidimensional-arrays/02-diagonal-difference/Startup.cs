namespace _02_diagonal_difference
{
    using System;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                primaryDiagonal += matrix[i, i];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                secondaryDiagonal += matrix[n - i - 1, i];
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}
