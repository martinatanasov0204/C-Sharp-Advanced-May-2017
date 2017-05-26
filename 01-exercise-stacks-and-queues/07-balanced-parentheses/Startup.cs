namespace _07_balanced_parentheses
{
    using System;
    using System.Collections.Generic;
    class Startup
    {
        static void Main()
        {
            var parenthesis = Console.ReadLine();

            Queue<int> leftQueue = new Queue<int>();
            Stack<int> rightStack = new Stack<int>();

            if (parenthesis.Length % 2 != 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                int halfSize = parenthesis.Length / 2;

                var leftPart = parenthesis.Substring(0, halfSize);
                var rightPart = parenthesis.Substring(halfSize, parenthesis.Length - halfSize);

                foreach (char each in leftPart)
                {
                    leftQueue.Enqueue(each);
                }

                foreach (char each in rightPart)
                {
                    rightStack.Push(each);
                }

                bool isEqual = true;
                
                // So stupid way, but it works somehow

                while (leftQueue.Count > 0)
                {
                    int a = leftQueue.Dequeue();
                    int b = rightStack.Pop();

                    if ((a + 1 != b && b == 41) && (a + 2 != b && b != 93) && (a + 2 != b && b != 125))
                    {
                        isEqual = false;
                        Console.WriteLine("NO");
                        break;
                    }
                }

                if (isEqual)
                {
                    Console.WriteLine("YES");
                }
            }
        }
    }
}
