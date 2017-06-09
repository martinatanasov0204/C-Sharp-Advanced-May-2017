namespace _03_formatting_numbers
{
	using System;
	using System.Linq;
	class Startup
	{
		static void Main()
		{
			double[] nums = Console.ReadLine()
				.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(double.Parse)
				.ToArray();

			int a = int.Parse(nums[0].ToString());
			double b = nums[1];
			double c = nums[2];

			string aHexFormat = int.Parse(a.ToString()).ToString("X");
			string aBinary = Convert.ToString(int.Parse(a.ToString()), 2);

			if (aBinary.Length > 10)
			{
				aBinary = aBinary.Substring(0, 10);
			}

			Console.WriteLine($"|{aHexFormat,-10}|{aBinary.PadLeft(10, '0')}|{b,10:F2}|{c,-10:F3}|");
		}
	}
}
