namespace _01_reverse_strings
{
    using System;
    using System.Collections.Generic;
    class Startup
    {
        static void Main()
        {
            var input = Console.ReadLine();
            Stack<char> reversedInput = new Stack<char>();

            foreach (char symbol in input)
            {
                reversedInput.Push(symbol);
            }

            Console.WriteLine(string.Join("", reversedInput));
        }
    }
}
