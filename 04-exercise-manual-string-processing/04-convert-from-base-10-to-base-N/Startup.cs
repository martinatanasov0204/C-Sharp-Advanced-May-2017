namespace _04_convert_from_base_10_to_base_N
{
	using System;
	using System.Linq;
	using System.Text;
	using System.Numerics;
	class Startup
	{
		static void Main()
		{
			BigInteger[] input = Console.ReadLine()
					.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
					.Select(BigInteger.Parse)
					.ToArray();

			BigInteger newBase = input[0];
			BigInteger digit = input[1];

			StringBuilder result = new StringBuilder();

			if (digit < newBase)
			{
				Console.WriteLine(digit);
			}
			else
			{
				while (digit >= newBase)
				{
					result.Append(digit % newBase);
					digit /= newBase;
				}

				if (digit > 0)
				{
					result.Append(digit);
				}

				Console.WriteLine(string.Join("", result.ToString().Reverse()));
			}
		}
	}
}
