using System;
using System.Collections.Generic;

namespace planets_and_probes_and_KeyValuePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>()
            {
                "Mercury",
                "Venus",
                "Earth",
                "Mars",
                "Jupiter",
                "Saturn",
                "Uranus",
                "Neptune"
            };

            List<KeyValuePair<string, string>> probeDestinations = new List<KeyValuePair<string, string>>();

            probeDestinations.Add(new KeyValuePair<string, string>("Viking 1", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 1", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 1", "Jupiter"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 1", "Saturn"));

            // Iterate planets
            foreach (string planet in planetList)
            {
                // List to store probes that visited the planet
                List<string> matchingProbes = new List<string>();

                // Iterate probeDestinations
                foreach (KeyValuePair<string, string> probeDest in probeDestinations)
                {
                    /*
                        Does the current probe's destination
                        match the value of the `planet` variable?
                        If so, add it to the list.
                    */
                    if (planet == probeDest.Value)
                    {
                        matchingProbes.Add(probeDest.Key);
                    }
                }

                string probes = String.Join(",", matchingProbes);
                Console.WriteLine($"{planet}: {probes}");
            }
        }
    }
}
