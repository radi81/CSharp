namespace _10.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounterEx
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> worldPopulationData =
                new Dictionary<string, Dictionary<string, long>>();

            while (input != "report")
            {
                string[] cityCountryPopulation = input.Split('|');
                string city = cityCountryPopulation[0];
                string country = cityCountryPopulation[1];
                long populationCount = long.Parse(cityCountryPopulation[2]);

                if (!worldPopulationData.ContainsKey(country))
                {
                    worldPopulationData.Add(country, new Dictionary<string, long>());
                }

                if (!worldPopulationData[country].ContainsKey(city))
                {
                    worldPopulationData[country].Add(city, populationCount);
                }
                else
                {
                    worldPopulationData[country][city] += populationCount;
                }

                input = Console.ReadLine();
            }

            long countryPopulationSum = 0;
            foreach (var outerPair in worldPopulationData.OrderByDescending(x => x.Value.Values.Sum()))
            {
                foreach (var innerPair in outerPair.Value)
                {
                    countryPopulationSum += innerPair.Value;                    
                }

                Console.WriteLine("{0} (total population: {1})", outerPair.Key, countryPopulationSum);

                foreach (var innerPair in outerPair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("=>{0}: {1}", innerPair.Key, innerPair.Value);
                }

                countryPopulationSum = 0;
            }
        }
    }
}
