namespace _06_count_substring_occurrences
{
	using System;
	class Startup
	{
		static void Main()
		{
			string text = Console.ReadLine().ToLower();
			string regex = Console.ReadLine().ToLower();

			int count = 0;

			while (text.Contains(regex))
			{
				int index = text.IndexOf(regex);

				text = text.Substring(index + 1);

				count++;
			}

			Console.WriteLine(count);
		}
	}
}
