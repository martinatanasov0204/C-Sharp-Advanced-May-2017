namespace _05_rubiks_matrix
{
    using System;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            var param = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numberOfCommands = int.Parse(Console.ReadLine());

            int row = param[0];
            int col = param[1];

            int[,] matrix = new int[row, col];

            int number = 1;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = number++;
                }
            }

            for (int i = 0; i < numberOfCommands; i++)
            {
                var command = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string toMove = string.Empty;
                string direction = command[1];
                int moves = int.Parse(command[2]);

                if (direction == "up" || direction == "down")
                {
                    toMove = "column";
                }
                else
                {
                    toMove = "row";
                }

                if (toMove == "row")
                {
                    
                }
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
    }
}
