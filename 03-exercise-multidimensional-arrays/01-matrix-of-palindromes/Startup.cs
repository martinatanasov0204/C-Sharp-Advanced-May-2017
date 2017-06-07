namespace _01_matrix_of_palindromes
{
    using System;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            var param = Console.ReadLine()
                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int row = param[0];
            int col = param[1];

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string[,] matrix = new string[row, col];

            int position = 0;
            int middlePosition = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = GetCurrElementAsString(alphabet[position], alphabet[middlePosition], alphabet[position]);
                    middlePosition++;
                }

                position++;
                middlePosition = position;
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static string GetCurrElementAsString(char a, char b, char c)
        {
            return a.ToString() + b.ToString() + c.ToString();
        }
    }
}
