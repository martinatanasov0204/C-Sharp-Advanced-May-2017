namespace _09_text_filter
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	class Startup
	{
		static void Main()
		{
			List<string> separators = Console.ReadLine()
				.Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			string text = Console.ReadLine();

			foreach (var separator in separators)
			{
				text = text.Replace(separator, new string('*', separator.Length));
			}

			Console.WriteLine(text);
		}
	}
}
