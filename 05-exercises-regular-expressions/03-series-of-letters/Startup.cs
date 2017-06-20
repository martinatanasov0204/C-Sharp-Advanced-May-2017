namespace _03_series_of_letters
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	class Startup
	{
		static void Main()
		{
			string input = Console.ReadLine();

			Stack<char> stack = new Stack<char>();

			foreach (var character in input)
			{
				if (stack.Count == 0)
				{
					stack.Push(character);
				}
				else if (character != stack.Peek())
				{
					stack.Push(character);
				}
			}

			Console.WriteLine(string.Join("", stack).Reverse().ToArray());
		}
	}
}
