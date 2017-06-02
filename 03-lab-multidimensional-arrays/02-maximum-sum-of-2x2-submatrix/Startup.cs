namespace _02_maximum_sum_of_2x2_submatrix
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    class Startup
    {
        static void Main()
        {
            var param = Regex.Split(Console.ReadLine(), ", ").Select(int.Parse).ToList();

            int row = param[0];
            int col = param[1];

            double[,] matrix = new double[row, col];

            for (int i = 0; i < row; i++)
            {
                var line = Regex.Split(Console.ReadLine(), ", ").Select(int.Parse).ToList();

                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            double max = double.MinValue;
            int indexRow = 0;
            int indexCol = 0;

            for (int i = 0; i < row - 1; i++)
            {
                double currSum = 0;

                for (int j = 0; j < col - 1; j++)
                {
                    currSum += matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (currSum > max)
                    {
                        indexRow = i;
                        indexCol = j;

                        max = currSum;
                    }

                    currSum = 0;
                }
            }

            Console.WriteLine(matrix[indexRow, indexCol] + " " + matrix[indexRow, indexCol + 1]);
            Console.WriteLine(matrix[indexRow + 1, indexCol] + " " + matrix[indexRow + 1, indexCol + 1]);
            Console.WriteLine(max);
        }
    }
}
