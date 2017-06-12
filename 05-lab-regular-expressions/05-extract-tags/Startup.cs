namespace _05_extract_tags
{
	using System;
	using System.Text.RegularExpressions;
	class Startup
	{
		static void Main()
		{
			string line = Console.ReadLine();

			Regex regex = new Regex("<.*?>");

			while (line != "END")
			{
				MatchCollection matches = regex.Matches(line);

				foreach (Match match in matches)
				{
					Console.WriteLine(match);
				}

				line = Console.ReadLine();
			}
		}
	}
}
