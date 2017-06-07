namespace _02_parse_urls
{
    using System;
    using System.Text.RegularExpressions;
    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var protocolSeparator = Regex.Split(input, "(?:://)");
            var resourceSeparator = Regex.Split(protocolSeparator[1], "(/)");

            if (protocolSeparator.Length > 2 || protocolSeparator.Length == 0 || resourceSeparator.Length < 2)
            {
                Console.WriteLine("Invalid URL");
            }
            else
            {
                var resourcesPart = protocolSeparator[1];
                var resources = resourcesPart.Substring(resourcesPart.IndexOf("/") + 1, resourcesPart.Length - resourcesPart.IndexOf("/") - 1);

                Console.WriteLine($"Protocol = {protocolSeparator[0]}");
                Console.WriteLine($"Server = {resourceSeparator[0]}");
                Console.WriteLine($"Resources = {resources}");
            }
        }
    }
}
