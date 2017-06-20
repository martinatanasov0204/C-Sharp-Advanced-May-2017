namespace _03_NMS
{
	using System;
	using System.Collections.Generic;

	class Startup
	{
		static void Main()
		{
			string line = Console.ReadLine();

			List<string> container = new List<string>();

			string text = string.Empty;

			while (line != "---NMS SEND---")
			{
				text += line;

				line = Console.ReadLine();
			}

			int startIndex = 0;
			int endIndex = 0;

			for (int i = 0; i < text.Length - 1; i++)
			{
				int alphabetPositionLeft;
				int alphabetPositionRight;


				if (text[i] >= 97)
				{
					alphabetPositionLeft = text[i] - 96;
				}
				else
				{
					alphabetPositionLeft = text[i] - 64;
				}

				if (text[i + 1] >= 97)
				{
					alphabetPositionRight = text[i + 1] - 96;
				}
				else
				{
					alphabetPositionRight = text[i + 1] - 64;
				}

				if (alphabetPositionLeft > alphabetPositionRight)
				{
					endIndex = i + 1;

					container.Add(text.Substring(startIndex, endIndex - startIndex));
					
					startIndex = i + 1;
				}
			}

			container.Add(text.Substring(endIndex));

			string delimiter = Console.ReadLine();

			Console.WriteLine(string.Join(delimiter, container));
		}
	}
}
