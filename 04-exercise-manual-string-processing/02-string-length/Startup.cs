namespace _02_string_length
{
	using System;
	class Startup
	{
		static void Main()
		{
			string str = Console.ReadLine();

			if (str.Length > 20)
			{
				Console.WriteLine(str.Substring(0, 20));
			}
			else
			{
				Console.WriteLine(str.Substring(0, str.Length) + new string('*', 20 - str.Length));
			}
		}
	}
}
