namespace _04_pascal_triangle
{
    using System;
    class Startup
    {
        static void Main()
        {
            var height = int.Parse(Console.ReadLine());

            int[][] triangle = new int[height][];
            int currentWidth = 1;

            for (int i = 0; i < height; i++)
            {
                triangle[i] = new int[currentWidth];

                int[] currentRow = triangle[i];
                currentRow[0] = 1;
                currentRow[currentRow.Length - 1] = 1;
                currentWidth++;

                if (currentRow.Length > 2)
                {
                    for (int j = 1; j < currentRow.Length - 1; j++)
                    {
                        int[] previousRow = triangle[i - 1];
                        int prevoiousRowSum = previousRow[j] + previousRow[j - 1];
                        currentRow[j] = prevoiousRowSum;
                    }
                }
            }

            for (int i = 0; i < triangle.Length; i++)
            {
                for (int j = 0; j < triangle[i].Length; j++)
                {
                    Console.Write(triangle[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
