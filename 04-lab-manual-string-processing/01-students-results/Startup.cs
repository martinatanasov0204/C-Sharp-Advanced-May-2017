namespace _01_students_results
{
    using System;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0, -10}|{1,7}|{2,7}|{3,7}|{4,7}|", 
                   "Name","CAdv", "COOP", "AdvOOP", "Average");

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split(new[] {' ', ',', '-'}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string studentName = line[0];
                double cAdvancedMark = double.Parse(line[1]);
                double cOOPMark = double.Parse(line[2]);
                double advancedOOP = double.Parse(line[3]);
                double average = (cAdvancedMark + cOOPMark + advancedOOP) / 3;

                Console.WriteLine("{0, -10:}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|",
                    studentName, cAdvancedMark, cOOPMark, advancedOOP, average);

            }
        }
    }
}
