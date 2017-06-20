namespace _06_reverse_and_exclude
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	class Startup
	{
		static void Main()
		{
			List<int> numbers = Console.ReadLine()
				.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			int divider = int.Parse(Console.ReadLine());

			List<int> currNumbers = numbers;

			Predicate<int> checker = n => { return n % divider == 0; };
			Action<List<int>> reverser = nums => nums.Reverse();
			Action<List<int>> printer = nums => string.Join(" ", nums);
			Action<int> remover = n => numbers.Remove(n);

			reverser(numbers);

			foreach (var number in currNumbers)
			{
				if (checker(number))
				{
					remover(number);
				}
			}

			printer(numbers);
		} 
	}
}
