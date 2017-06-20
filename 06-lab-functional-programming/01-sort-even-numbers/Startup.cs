namespace _01_sort_even_numbers
{
	using System;
	using System.Linq;

	class Startup
	{
		static void Main()
		{
			Console.WriteLine(string.Join(", ", Console.ReadLine()
				.Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.Where(n => n % 2 == 0)
				.OrderBy(n => n)));
		}
	}
}
