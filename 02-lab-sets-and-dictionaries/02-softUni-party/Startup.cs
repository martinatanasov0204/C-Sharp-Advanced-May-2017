namespace _02_softUni_party
{
    using System;
    using System.Collections.Generic;
    class Startup
    {
        static void Main()
        {
            string person = Console.ReadLine();

            SortedSet<string> invitedVipGuests = new SortedSet<string>();
            SortedSet<string> invitedRegularGuests = new SortedSet<string>();
            SortedSet<string> vipGuests = new SortedSet<string>();
            SortedSet<string> regularGuests = new SortedSet<string>();

            int num;        
            
            // Store invited gusts in: regular and vip    

            while (person != "PARTY")
            {
                if (int.TryParse(person[0].ToString(), out num))
                {
                    if (!invitedVipGuests.Contains(person))
                    {
                        invitedVipGuests.Add(person);
                    }
                }
                else
                {
                    if (!invitedRegularGuests.Contains(person))
                    {
                        invitedRegularGuests.Add(person);
                    }
                }
                person = Console.ReadLine();
            }

            person = Console.ReadLine();

            // Store guest who have come

            while (person != "END")
            {
                if (int.TryParse(person[0].ToString(), out num))
                {
                    if (!vipGuests.Contains(person) && invitedVipGuests.Contains(person))
                    {
                        vipGuests.Add(person);
                    }
                }
                else
                {
                    if (!regularGuests.Contains(person) && invitedRegularGuests.Contains(person))
                    {
                        regularGuests.Add(person);
                    }
                }

                person = Console.ReadLine();
            }

            Console.WriteLine(invitedVipGuests.Count + invitedRegularGuests.Count - vipGuests.Count - regularGuests.Count);

            // Print guest who were invited, but did not come

            foreach (var invitedVipGuest in invitedVipGuests)
            {
                if (!vipGuests.Contains(invitedVipGuest))
                {
                    Console.WriteLine(invitedVipGuest);
                }
            }

            foreach (var invitedRegularGuest in invitedRegularGuests)
            {
                if (!regularGuests.Contains(invitedRegularGuest))
                {
                    Console.WriteLine(invitedRegularGuest);
                }
            }
        }
    }
}
