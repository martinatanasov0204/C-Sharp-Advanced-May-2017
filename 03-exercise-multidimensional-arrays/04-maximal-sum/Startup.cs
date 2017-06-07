namespace _04_maximal_sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Startup
    {
        static void Main()
        {
            var param = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int row = param[0];
            int col = param[1];

            int[,] matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                var line = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            int max = int.MinValue;

            int indexRow = 0;
            int indexCol = 0;

            for (int i = 0; i < row - 2; i++)
            {
                for (int j = 0; j < col - 2; j++)
                {
                    int currSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2];
                    currSum += matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2];
                    currSum += matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (currSum > max)
                    {
                        indexRow = i;
                        indexCol = j;

                        max = currSum;
                    }
                }
            }

            Console.WriteLine($"Sum = {max}");
            Console.WriteLine(matrix[indexRow, indexCol] + " " + matrix[indexRow, indexCol + 1] + " " + matrix[indexRow, indexCol + 2]);
            Console.WriteLine(matrix[indexRow + 1, indexCol] + " " + matrix[indexRow + 1, indexCol + 1] + " " + matrix[indexRow + 1, indexCol + 2]);
            Console.WriteLine(matrix[indexRow + 2, indexCol] + " " + matrix[indexRow + 2, indexCol + 1] + " " + matrix[indexRow + 2, indexCol + 2]);

        }
    }
}
