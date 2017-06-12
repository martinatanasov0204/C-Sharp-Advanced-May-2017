namespace _07_valid_time
{
	using System;
	using System.Text.RegularExpressions;
	class Startup
	{
		static void Main()
		{
			string hour = Console.ReadLine();
			Regex regex = new Regex(@"^(([0][0-9]:[0-5][0-9]:[0-5][0-9] AM)|
										([1][12]:[0-5][0-9]:[0-5][0-9] AM)|
										([0][0-9]:[0-5][0-9]:[0-5][0-9] PM)|
										([1][12]:[0-5][0-9]:[0-5][0-9] PM))$");

			while (hour != "END")
			{
				Match match = regex.Match(hour);

				if (match.Success)
				{
					Console.WriteLine("valid");
				}
				else
				{
					Console.WriteLine("invalid");
				}

				hour = Console.ReadLine();
			}
		}
	}
}
