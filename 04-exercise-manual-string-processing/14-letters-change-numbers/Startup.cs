namespace _14_letters_change_numbers
{
	using System;
	using System.Linq;
	class Startup
	{
		static void Main()
		{
			string[] param = Console.ReadLine()
				.Split(new[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries)
				.ToArray();

			double totalSum = 0;

			foreach (var word in param)
			{
				double currSum = 0;

				char firstLetter = word[0];
				double number = double.Parse(word.Substring(1, word.Length - 2));
				char lastLetter = word[word.Length - 1];

				if (char.IsUpper(firstLetter))
				{
					currSum += number / (firstLetter - 64);
				}
				else
				{
					currSum += number * (firstLetter - 96);
				}

				if (char.IsUpper(lastLetter))
				{
					currSum -= lastLetter - 64;
				}
				else
				{
					currSum += lastLetter - 96;
				}

				totalSum += currSum;
			}

			Console.WriteLine($"{totalSum:F2}");
		}
	}
}
