namespace _06_sentence_extractor
{
	using System;
	using System.Text.RegularExpressions;

	class Startup
	{
		static void Main()
		{
			string keyword = Console.ReadLine();
			string text = Console.ReadLine();

			Regex splitToSentences = new Regex(".*?[\\.!\\?]");
			Regex checkInSentence = new Regex($"\\b{keyword}\\b");

			MatchCollection sentences = splitToSentences.Matches(text);

			foreach (Match sentence in sentences)
			{
				Match match = checkInSentence.Match(sentence.ToString());

				if (match.Success)
				{
					Console.WriteLine(sentence);
				}
			}
		}
	}
}
