namespace _02_natures_prophet
{
	using System;
	using System.Linq;
	using System.Collections.Generic;

	class Startup
	{
		static void Main()
		{
			List<int> param = Console.ReadLine()
				.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			int n = param[0];
			int m = param[1];

			int[][] matrix = new int[n][];

			for (int i = 0; i < n; i++)
			{
				matrix[i] = new int[m];
				for (int j = 0; j < m; j++)
				{
					matrix[i][j] = 0;
				}
			}

			string line = Console.ReadLine();

			while (line != "Bloom Bloom Plow")
			{
				List<int> positions = line
					.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToList();

				int row = positions[0];
				int col = positions[1];

				for (int i = 0; i < n; i++)
				{
					matrix[row][i]++;
				}

				for (int i = 0; i < m; i++)
				{
					if (i != row)
					{
						matrix[i][col]++;
					}
				}

				line = Console.ReadLine();
			}

			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(string.Join(" ", matrix[i]));
			}
		}
	}
}
