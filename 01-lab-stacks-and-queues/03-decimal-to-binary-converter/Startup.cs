namespace _03_decimal_to_binary_converter
{
    using System;
    using System.Collections.Generic;
    class Startup
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            Stack<int> binaryStack = new Stack<int>();

            if (num == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (num > 0)
                {
                    var reminder = num%2;
                    binaryStack.Push(reminder);

                    num /= 2;
                }
            }

            while (binaryStack.Count > 0)
            {
                Console.Write(binaryStack.Pop());
            }
            Console.WriteLine();
        }
    }
}
