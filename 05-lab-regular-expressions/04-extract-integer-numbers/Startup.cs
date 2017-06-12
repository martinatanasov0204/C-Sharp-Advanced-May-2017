namespace _04_extract_integer_numbers
{
	using System;
	using System.Text.RegularExpressions;
	class Startup
	{
		static void Main()
		{
			string line = Console.ReadLine();

			Regex regex = new Regex("[0-9]+");
			MatchCollection matches = regex.Matches(line);

			foreach (var match in matches)
			{
				Console.WriteLine(match);
			}
		}
	}
}
