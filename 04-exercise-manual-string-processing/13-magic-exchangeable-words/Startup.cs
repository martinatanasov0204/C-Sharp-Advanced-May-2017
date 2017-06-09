namespace _13_magic_exchangeable_words
{
	using System;
	using System.Linq;
	class Startup
	{
		static void Main()
		{
			var words = Console.ReadLine()
					.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
					.ToArray();

			if (words[0].ToCharArray().Distinct().Count() != words[1].ToCharArray().Distinct().Count())
			{
				Console.WriteLine("false");
			}
			else
			{
				Console.WriteLine("true");
			}
		}
	}
}
