namespace _03_non_digit_count
{
	using System;
	using System.Text.RegularExpressions;
	class Startup
	{
		static void Main()
		{
			string line = Console.ReadLine();

			Regex regex = new Regex("[^0-9]");
			MatchCollection matches = regex.Matches(line);

			Console.WriteLine($"Non-digits: {matches.Count}");
		}
	}
}
