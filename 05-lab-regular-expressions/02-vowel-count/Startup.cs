namespace _02_vowel_count
{
	using System;
	using System.Text.RegularExpressions;
	class Startup
	{
		static void Main()
		{
			string line = Console.ReadLine();

			Regex regex = new Regex("[AEIOUYaeiouy]");
			MatchCollection matches = regex.Matches(line);

			Console.WriteLine($"Vowels: {matches.Count}");
		}
	}
}
