namespace _04_special_words
{
	using System;
	using System.Linq;
	class Startup
	{
		static void Main()
		{
			var separators = Console.ReadLine()
				.Split(new[] { ' ' })
				.ToList();

			var text = Console.ReadLine()
				.Split(new[] { '(', ')', '[', ']', '<', '>', ',', '-', '!', '?', ' ' })
				.ToList(); 

			// Shitty way but it works

			foreach (var separator in separators)
			{
				int count = 0;

				foreach (var word in text)
				{
					if (word == separator)
					{
						count++;
					}
				}

				Console.WriteLine($"{separator} - {count}");
			}
		}
	}
}
