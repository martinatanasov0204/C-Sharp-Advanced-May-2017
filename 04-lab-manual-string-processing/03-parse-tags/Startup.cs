namespace _03_parse_tags
{
	using System;
	class Startup
	{
		static void Main()
		{
			string line = Console.ReadLine();

			while (line.Contains("</upcase"))
			{
				string str = line.Substring(line.IndexOf("<upcase") + 8, line.IndexOf("</upcase") - line.IndexOf("<upcase") - 8).ToUpper();

				var partToReplace = line.Substring(line.IndexOf("<upcase"), line.IndexOf("</upcase") + 9 - line.IndexOf("<upcase"));

				line = line.Replace(partToReplace, str);
			}

			Console.WriteLine(line);
		}
	}
}
