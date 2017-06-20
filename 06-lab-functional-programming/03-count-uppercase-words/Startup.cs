namespace _03_count_uppercase_words
{
	using System;
	using System.Linq;

	class Startup
	{
		static void Main()
		{
			Console.ReadLine()
				.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
				.Where(w => Char.IsUpper(w[0]))
				.Select(w => w)
				.ToList()
				.ForEach(e => Console.WriteLine(e));
		}
	}
}
