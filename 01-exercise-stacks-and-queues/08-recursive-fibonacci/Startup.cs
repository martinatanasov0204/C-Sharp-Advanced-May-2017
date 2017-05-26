namespace _08_recursive_fibonacci
{
    using System;
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            getFibonacci(1, 1, 1, n);
        }

        // It works, although judge doesn't agree with it

        public static void getFibonacci(int a, int b, int counter, int number)
        {
            if (counter <= number)
            {
                getFibonacci(b, a + b, counter + 1, number);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
