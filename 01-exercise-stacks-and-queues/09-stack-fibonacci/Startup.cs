namespace _09_stack_fibonacci
{
    using System;
    using System.Collections.Generic;
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> fib = new Stack<int>();

            fib.Push(1);
            fib.Push(1);

            // Again it works, but judge doesn't like it

            for (int i = 0; i < n - 1; i++)
            {
                int a = fib.Pop();
                int b = fib.Peek();
                fib.Push(a);
                fib.Push(a + b);
            }

            Console.WriteLine(fib.Peek());
        }
    }
}
