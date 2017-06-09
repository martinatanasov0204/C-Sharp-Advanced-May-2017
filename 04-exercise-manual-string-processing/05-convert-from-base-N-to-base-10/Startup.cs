namespace _05_convert_from_base_N_to_base_10
{
	using System;
	using System.Linq;
	using System.Numerics;
	class Startup
	{
		static void Main()
		{
			string[] input = Console.ReadLine()
				   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				   .ToArray();

			string digitBase = input[0];
			string digit = input[1];

			BigInteger result = BigInteger.Parse(digit[digit.Length - 1].ToString());

			int power = 1;

			for (int i = digit.Length - 2; i >= 0; i--)
			{
				result += BigInteger.Parse(digit[i].ToString()) * BigInteger.Pow(BigInteger.Parse(digitBase), power);
				power++;
			}

			Console.WriteLine(result);
		}
	}
}
