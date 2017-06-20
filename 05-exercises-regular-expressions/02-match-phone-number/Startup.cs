namespace _02_match_phone_number
{
	using System;
	using System.Text.RegularExpressions;

	class Startup
	{
		static void Main()
		{
			string line = Console.ReadLine();

			Regex regex = new Regex("^\\+359( |-){1}[2]( |-){1}([0-9]{3})( |-){1}([0-9]{4})$");

			while (line != "end")
			{
				Match match = regex.Match(line);

				if (match.Success)
				{
					Console.WriteLine(line);
				}

				line = Console.ReadLine();
			}
		}
	}
}
