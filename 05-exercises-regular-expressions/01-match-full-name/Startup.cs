namespace _01_match_full_name
{
	using System;
	using System.Text.RegularExpressions;

	class Startup
	{
		static void Main()
		{
			string name = Console.ReadLine();

			Regex regex = new Regex("\\b[A-Z]{1}[a-z]{1,} [A-Z]{1}[a-z]{1,}\\b");
			
			while (name != "end")
			{
				Match match = regex.Match(name);

				if (match.Success)
				{
					Console.WriteLine(name);
				}

				name = Console.ReadLine();
			}
		}
	}
}
