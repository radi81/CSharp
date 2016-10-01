namespace _12.LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LegendaryFarmingEx
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool oneOfMaterialsWinsTheRace = false;
            SortedDictionary<string, float> marksOfKeyMaterials = new SortedDictionary<string, float>();
            SortedDictionary<string, float> marksOfJunkMaterials = new SortedDictionary<string, float>();
            string winningMaterial = null;

            marksOfKeyMaterials.Add("shards", 0);
            marksOfKeyMaterials.Add("fragments", 0);
            marksOfKeyMaterials.Add("motes", 0);

            while (true)
            {
                string[] inputData = input.Trim().Split(' ');

                for (int i = 0; i < inputData.Length; i = i + 2)
                {
                    float amountOfMaterial = float.Parse(inputData[i]);
                    string material = inputData[i + 1].ToLower();

                    if (material == "shards" ||
                        material == "fragments" ||
                        material == "motes")
                    {
                        marksOfKeyMaterials[material] += amountOfMaterial;

                        oneOfMaterialsWinsTheRace = 
                            CheckForWinningMaterial(
                                marksOfKeyMaterials, 
                                oneOfMaterialsWinsTheRace,
                                ref winningMaterial);

                        if (oneOfMaterialsWinsTheRace)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (!marksOfJunkMaterials.ContainsKey(material))
                        {
                            marksOfJunkMaterials.Add(material, amountOfMaterial);
                        }
                        else
                        {
                            marksOfJunkMaterials[material] += amountOfMaterial;
                        }
                    }
                }

                if (oneOfMaterialsWinsTheRace == false)
                {
                    input = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            marksOfKeyMaterials[winningMaterial] -= 250;

            var orderedByQuantityMarksOfKeyMaterials = marksOfKeyMaterials.OrderByDescending(x => x.Value);

            switch (winningMaterial)
            {
                case "shards":
                    Console.WriteLine("{0} obtained!", LegendaryItem.Shadowmourne);
                    break;
                case "fragments":
                    Console.WriteLine("{0} obtained!", LegendaryItem.Valanyr);
                    break;
                case "motes":
                    Console.WriteLine("{0} obtained!", LegendaryItem.Dragonwrath);
                    break;
                default:
                    break;
            }

            foreach (var kvp in orderedByQuantityMarksOfKeyMaterials)
            {
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            }

            foreach (var kvp in marksOfJunkMaterials)
            {
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            }
        }

        private static bool CheckForWinningMaterial(
            SortedDictionary<string, 
                float> marksOfKeyMaterials, 
            bool oneOfMaterialsWinsTheRace,
            ref string winningMaterial)
        {
            foreach (var kvp in marksOfKeyMaterials)
            {
                if (kvp.Value >= 200)
                {
                    oneOfMaterialsWinsTheRace = true;

                    winningMaterial = kvp.Key;
                }
            }

            return oneOfMaterialsWinsTheRace;
        }
    }
}
