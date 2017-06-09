namespace _10_unicode_characters
{
	using System;
	class Startup
	{
		static void Main()
		{
			string input = Console.ReadLine();

			foreach (var character in input)
			{
				string symbol = "\\u" + ((int)character).ToString("X4").ToLower();

				Console.Write(symbol);
			}

			Console.WriteLine();
		}
	}
}
