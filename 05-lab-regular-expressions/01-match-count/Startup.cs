﻿namespace _01_match_count
{
	using System;
	using System.Text.RegularExpressions;
	class Startup
	{
		static void Main()
		{
			string pattern = Console.ReadLine();
			string text = Console.ReadLine();

			Regex regex = new Regex(pattern);
			MatchCollection matches = regex.Matches(text);

			Console.WriteLine(matches.Count);
		}
	}
}
