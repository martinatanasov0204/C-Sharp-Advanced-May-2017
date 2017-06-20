namespace _04_add_VAT
{
	using System;
	using System.Linq;

	class Startup
	{
		static void Main()
		{
			Console.ReadLine()
				.Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
				.Select(double.Parse)
				.Select(n => n + n * 0.2)
				.ToList()
				.ForEach(n => Console.WriteLine($"{n:F2}"));
		}
	}
}
