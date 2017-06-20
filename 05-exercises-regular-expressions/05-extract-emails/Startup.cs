namespace _05_extract_emails
{
	using System;
	using System.Text.RegularExpressions;

	class Startup
	{
		static void Main()
		{
			string line = Console.ReadLine();

			Regex regex = new Regex(@"([a-zA-Z0-9]+[-\._]*[a-zA-Z0-9]+)@([a-zA-Z]+[-]*[a-zA-Z]+)(\.[a-z]+)+");

			MatchCollection matches = regex.Matches(line);

			foreach (Match match in matches)
			{
				Console.WriteLine(match);
			}
		}
	}
}
