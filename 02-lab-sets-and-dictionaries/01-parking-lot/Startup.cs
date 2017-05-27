namespace _01_parking_lot
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    class Startup
    {
        static void Main()
        {
            string line = Console.ReadLine();
            SortedSet<string> parking = new SortedSet<string>();

            while (line != "END")
            {
                var car = Regex.Split(line, ", ");

                if (car[0] == "IN")
                {
                    parking.Add(car[1]);
                }
                else
                {
                    parking.Remove(car[1]);
                }

                line = Console.ReadLine();
            }

            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
