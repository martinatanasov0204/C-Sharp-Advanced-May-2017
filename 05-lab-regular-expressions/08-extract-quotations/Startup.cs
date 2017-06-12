namespace _08_extract_quotations
{
	using System;
	using System.Text.RegularExpressions;
	class Startup
	{
		static void Main()
		{
			string line = Console.ReadLine();
			
			Regex regex = new Regex("(\'.*?\')|(\"[^\"]*\")");

			MatchCollection matches = regex.Matches(line);

			foreach (var match in matches)
			{
				string quote = match.ToString();

				Console.WriteLine(quote.Substring(1, quote.Length - 2));
			}
		}
	}
}
