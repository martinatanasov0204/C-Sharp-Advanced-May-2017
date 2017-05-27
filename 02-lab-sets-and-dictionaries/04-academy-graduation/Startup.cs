namespace _04_academy_graduation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            SortedDictionary<string, double> dictionary = new SortedDictionary<string, double>();

            string studentName = string.Empty;

            for (int i = 0; i < num * 2; i++)
            {
                string line = Console.ReadLine();

                if (i % 2 == 0)
                {
                    studentName = line;
                }
                else
                {
                    double avgGrades = line.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList().Average();
                    dictionary.Add(studentName, avgGrades);
                }
            }

            foreach (var student in dictionary)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value}");
            }
        }
    }
}
