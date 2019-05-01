namespace L04.CitiesByContinentAndCountry
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CitiesByContinentAndCountry
    {
        public static void Main()
        {
            int rotation = int.Parse(Console.ReadLine());

            // Applies for the dictionary below: <key is continentName>, <value.Key is countryName, value.Value is cityName>
            Dictionary<string, Dictionary<string, List<string>>> continentsDatabase = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < rotation; i++)
            {
                //Europe Bulgaria Sofia - input format
                string[] inputContinentDetails = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string continentName = inputContinentDetails[0];
                string countryName = inputContinentDetails[1];
                string cityName = inputContinentDetails[2];

                if (!continentsDatabase.ContainsKey(continentName))
                {
                    continentsDatabase[continentName] = new Dictionary<string, List<string>>();
                }

                if (!continentsDatabase[continentName].ContainsKey(countryName))
                {
                    continentsDatabase[continentName][countryName] = new List<string>();
                }

                continentsDatabase[continentName][countryName].Add(cityName);
            }

            foreach (var continentKVP in continentsDatabase)
            {
                Console.WriteLine($"{continentKVP.Key}:");

                foreach (var countryKVP in continentKVP.Value)
                {
                    Console.WriteLine($"{countryKVP.Key} -> {string.Join(", ", countryKVP.Value)}");
                }
            }
        }
    }
}
