namespace _05_hot_potato
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            var children = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int num = int.Parse(Console.ReadLine());

            Queue<string> removedChildren = new Queue<string>();

            int numberOfChildren = children.Count;
            int position;

            if (num % children.Count == 0)
            {
                position = children.Count - 1;
            }
            else
            {
                position = num % children.Count - 1;
            }

            removedChildren.Enqueue(children[position]);
            children.RemoveAt(position);

            while (removedChildren.Count < numberOfChildren)
            {
                if (position == children.Count - 1)
                {
                    position = 0;
                }
                else
                {
                    position = (num + position - 1) % children.Count;
                }
                removedChildren.Enqueue(children[position]);
                children.RemoveAt(position);
            }

            while (removedChildren.Count > 1)
            {
                Console.WriteLine($"Removed {removedChildren.Dequeue()}");
            }

            Console.WriteLine($"Last is {removedChildren.Dequeue()}");
        }
    }
}
