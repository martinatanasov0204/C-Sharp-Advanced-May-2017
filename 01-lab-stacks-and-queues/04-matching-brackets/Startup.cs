namespace _04_matching_brackets
{
    using System;
    using System.Collections.Generic;
    class Startup
    {
        static void Main()
        {
            var input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (input[i] == ')')
                {
                    int startPos = indexes.Pop();
                    int endPos = i;

                    var toPrint = input.Substring(startPos, endPos - startPos + 1);

                    Console.WriteLine(toPrint);
                }
            }
        }
    }
}
