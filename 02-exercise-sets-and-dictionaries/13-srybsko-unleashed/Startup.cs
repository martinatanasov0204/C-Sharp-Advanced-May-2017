namespace _13_srybsko_unleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Startup
    {
        static void Main()
        {
            string line = Console.ReadLine();

            //TODO: To finish the task using regex

            while (line != "End")
            {
                var parts = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                if (parts[2].Substring(0, 1) == "@")
                {
                    var singer = parts[0] + " " + parts[1];
                }
                else
                {
                    var singer = parts[0];
                }

                int ticketPrice;

                if (int.TryParse(parts[4], out ticketPrice))
                {
                    continue;
                }
                else
                {
                }

                line = Console.ReadLine();
            }
        }
    }
}
