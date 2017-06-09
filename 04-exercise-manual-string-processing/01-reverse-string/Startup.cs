namespace _01_reverse_string
{
	using System;
	class Startup
	{
		static void Main()
		{
			string str = Console.ReadLine();

			char[] arr = str.ToCharArray();
			Array.Reverse(arr);

			Console.WriteLine(new string(arr));
		}
	}
}
