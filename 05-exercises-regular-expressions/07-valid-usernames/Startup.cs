namespace _07_valid_usernames
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text.RegularExpressions;

	class Startup
	{
		static void Main()
		{
			List<string> usernames = Console.ReadLine()
				.Split(new[] {' ', '/', '\\', '(', ')'}, StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			List<string> validUsernames = new List<string>();

			Regex regex = new Regex("^[a-zA-Z]\\w{2,24}$");

			foreach (var username in usernames)
			{
				Match match = regex.Match(username);

				if (match.Success)
				{
					validUsernames.Add(username);
				}
			}

			int index = 0;
			int maxLength = int.MinValue;

			for (int i = 0; i < validUsernames.Count - 1; i++)
			{
				int sumOfLenghts = validUsernames[i].Length + validUsernames[i + 1].Length;

				if (sumOfLenghts > maxLength)
				{
					index = i;

					maxLength = sumOfLenghts;
				}
			}

			Console.WriteLine(validUsernames[index++]);
			Console.WriteLine(validUsernames[index]);
		}
	}
}
