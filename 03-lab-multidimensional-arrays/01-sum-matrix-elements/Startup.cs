namespace _01_sum_matrix_elements
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

            double sumOfAllElements = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sumOfAllElements += matrix[i, j];
                }
            }

            Console.WriteLine(row);
            Console.WriteLine(col);
            Console.WriteLine(sumOfAllElements);
        }
    }
}
