namespace _05_concatenate_strings
{
	using System;
	using System.Text;
	class Startup
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());

			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < n; i++)
			{
				string line = Console.ReadLine();
				sb.Append(line + " ");
			}

			Console.WriteLine(sb);
		}
	}
}
