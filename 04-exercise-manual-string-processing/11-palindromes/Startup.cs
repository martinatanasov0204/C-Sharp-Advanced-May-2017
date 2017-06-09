namespace _11_palindromes
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	class Startup
	{
		static void Main()
		{
			List<string> text = Console.ReadLine()
				.Split(new[] { ' ', '\t', ',', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			List<string> palindromes = new List<string>();

			foreach (var word in text)
			{
				if (word == string.Join("", word.Reverse()))
				{
					palindromes.Add(word);
				}
			}

			var dictionary = palindromes
				.GroupBy(str => str)
				.ToDictionary(group => group.Key, group => group.Count())
				.OrderBy(e => e.Key);

			int count = 0;

			Console.Write("[");

			foreach (var element in dictionary.Where(e => e.Value < 2))
			{
				if (count == dictionary.Count(e => e.Value < 2) - 1)
				{
					Console.Write(element.Key + "]");
				}
				else
				{
					Console.Write(element.Key + ", ");
				}

				count++;
			}

			Console.WriteLine();
		}
	}
}
