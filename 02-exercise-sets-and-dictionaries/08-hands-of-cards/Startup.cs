namespace _08_hands_of_cards
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            var line = Console.ReadLine();
            Dictionary<string, List<string>> peopleAndCards = new Dictionary<string, List<string>>();
            Dictionary<string, int> peopleAndResults = new Dictionary<string, int>();

            while (line != "JOKER")
            {
                var parts = Regex.Split(line, ": ");

                var personName = parts[0];
                var cards = Regex.Split(parts[1], ", ").ToList();

                if (peopleAndCards.ContainsKey(personName))
                {
                    foreach (var card in cards)
                    {
                        if (!peopleAndCards[personName].Contains(card))
                        {
                            peopleAndCards[personName].Add(card);
                        }
                    }
                }
                else
                {
                    peopleAndCards.Add(personName, new List<string>());

                    foreach (var card in cards)
                    {
                        if (!peopleAndCards[personName].Contains(card))
                        {
                            peopleAndCards[personName].Add(card);
                        }
                    }
                }               

                line = Console.ReadLine();
            }

            foreach (var person in peopleAndCards)
            {
                int cardsPoints = 0;

                foreach (var card in person.Value)
                {
                    int currCardPower = 0;

                    string cardPower = card.Substring(0, card.Length - 1);
                    string cardType = card[card.Length - 1].ToString();

                    switch (cardPower)
                    {
                        case "2":
                            currCardPower = 2;
                            break;
                        case "3":
                            currCardPower = 3;
                            break;
                        case "4":
                            currCardPower = 4;
                            break;
                        case "5":
                            currCardPower = 5;
                            break;
                        case "6":
                            currCardPower = 6;
                            break;
                        case "7":
                            currCardPower = 7;
                            break;
                        case "8":
                            currCardPower = 8;
                            break;
                        case "9":
                            currCardPower = 9;
                            break;
                        case "10":
                            currCardPower = 10;
                            break;
                        case "J":
                            currCardPower = 11;
                            break;
                        case "Q":
                            currCardPower = 12;
                            break;
                        case "K":
                            currCardPower = 13;
                            break;
                        case "A":
                            currCardPower = 14;
                            break;
                    }

                    switch (cardType)
                    {
                        case "S":
                            cardsPoints += 4 * currCardPower;
                            break;
                        case "H":
                            cardsPoints += 3 * currCardPower;
                            break;
                        case "D":
                            cardsPoints += 2 * currCardPower;
                            break;
                        case "C":
                            cardsPoints += currCardPower;
                            break;
                    }
                }

                peopleAndResults.Add(person.Key, cardsPoints);
            }

            foreach (var person in peopleAndResults)
            {
                Console.WriteLine($"{person.Key}: {person.Value}");
            }
        }
    }
}
