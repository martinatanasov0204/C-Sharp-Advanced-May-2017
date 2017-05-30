namespace _04_count_symbols
{
    using System;
    using System.Collections.Generic;
    class Startup
    {
        static void Main()
        {
            string text = Console.ReadLine();

            SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();

            foreach (char symbol in text)
            {
                if (dictionary.ContainsKey(symbol))
                {
                    dictionary[symbol]++;
                }
                else
                {
                    dictionary.Add(symbol, 1);
                }
            }

            foreach (var symbol in dictionary)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
