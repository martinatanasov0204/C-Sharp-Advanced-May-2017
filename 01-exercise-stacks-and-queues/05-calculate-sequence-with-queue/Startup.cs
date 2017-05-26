namespace _05_calculate_sequence_with_queue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            List<long> sequence = new List<long> {n};

            Queue<long> currentQueue = new Queue<long>();
            currentQueue.Enqueue(n);

            while (sequence.Count < 50)
            {
                var firstNumber = currentQueue.Peek() + 1;
                var secondNumber = currentQueue.Peek()*2 + 1;
                var thirdNumber = currentQueue.Peek() + 2;

                currentQueue.Enqueue(firstNumber);
                currentQueue.Enqueue(secondNumber);
                currentQueue.Enqueue(thirdNumber);

                sequence.Add(firstNumber);
                sequence.Add(secondNumber);
                sequence.Add(thirdNumber);

                currentQueue.Dequeue();
            }

            Console.WriteLine(string.Join(" ", sequence.Take(50)));
        }
    }
}
