namespace _06_valid_usernames
{
	using System;
	using System.Text.RegularExpressions;
	class Startup
	{
		static void Main()
		{
			string username = Console.ReadLine();

			Regex regex = new Regex(@"^[\w-_]{3,16}$");

			while (username != "END")
			{
				Match match = regex.Match(username);

				if (match.Success)
				{
					Console.WriteLine("valid");
				}
				else
				{
					Console.WriteLine("invalid");
				}

				username = Console.ReadLine();
			}
		}
	}
}
