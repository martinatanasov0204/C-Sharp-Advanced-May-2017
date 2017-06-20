namespace _04_replaceATag
{
	using System;
	using System.Text.RegularExpressions;

	class Startup
	{
		static void Main()
		{
			string line = Console.ReadLine();

			while (line != "end")
			{
				string pattern = @"<a href=("".+"")>(.*)<\/a>";
				string replace = @"[URL href=$1]$2[/URL]";

				string replaced = Regex.Replace(line, pattern, replace);

				Console.WriteLine(replaced);

				line = Console.ReadLine();
			}
		}
	}
}
