namespace _12_character_multiplier
{
	using System;
	class Startup
	{
		static void Main()
		{
			string[] param = Console.ReadLine().Split(' ');

			Console.WriteLine(CalculateSum(param[0], param[1]));
		}

		public static double CalculateSum(string a, string b)
		{
			double result = 0;

			if (a.Length == b.Length)
			{
				for (int i = 0; i < a.Length; i++)
				{
					result += a[i] * b[i];
				}
				return result;
			}

			if (a.Length < b.Length)
			{
				for (int i = 0; i < a.Length; i++)
				{
					result += a[i] * b[i];
				}

				for (int i = a.Length; i < b.Length; i++)
				{
					result += b[i];
				}

				return result;
			}

			// If a.Length > b.Length

			for (int i = 0; i < b.Length; i++)
			{
				result += a[i] * b[i];
			}

			for (int i = b.Length; i < a.Length; i++)
			{
				result += a[i];
			}

			return result;
			
		}
	}
}
