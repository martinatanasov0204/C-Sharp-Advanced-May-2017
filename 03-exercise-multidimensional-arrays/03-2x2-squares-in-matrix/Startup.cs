namespace _03_2x2_squares_in_matrix
{
    using System;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            var param = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int row = param[0];
            int col = param[1];

            int sum = 0;

            string[,] matrix = new string[row, col];

            for (int i = 0; i < row; i++)
            {
                var line = Console.ReadLine()
                    .Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            string element = string.Empty;

            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < col - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] && matrix[i + 1, j] == matrix[i + 1, j + 1] && matrix[i, j] == matrix[i + 1, j])
                    {
                        element = matrix[i, j];
                    }
                }
            }


            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < col - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] && matrix[i + 1, j] == matrix[i + 1, j + 1] 
                        && matrix[i, j] == matrix[i + 1, j] && element == matrix[i, j])
                    {
                        sum++;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
