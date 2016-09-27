namespace _12.LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LegendaryFarmingEx
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool oneOfMaterialsWinsTheRace = false;
            Dictionary<string, int> marksOfKeyMaterials = new Dictionary<string, int>();
            SortedDictionary<string, int> marksOfJunkMaterials = new SortedDictionary<string, int>();
            string winningMaterial = null;

            while (true)
            {              
                string[] inputData = input.Trim().Split(' ');

                for (int i = 0; i < inputData.Length; i = i + 2)
                {
                    int amountOfMaterial = int.Parse(inputData[i]);
                    string material = inputData[i + 1].ToLower();

                    if (material == "shards" ||
                        material == "fragments" ||
                        material == "motes")
                    {
                        if (!marksOfKeyMaterials.ContainsKey(material))
                        {
                            marksOfKeyMaterials.Add(material, amountOfMaterial);
                        }
                        else
                        {
                            marksOfKeyMaterials[material] += amountOfMaterial;
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

                foreach (var kvp in marksOfKeyMaterials)
                {
                    if (kvp.Value >= 200)
                    {
                        oneOfMaterialsWinsTheRace = true;

                        winningMaterial = kvp.Key;
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

            switch(winningMaterial)
            {
                case "shards":
                    Console.WriteLine("{0} obtained!", LegendaryItem.Shadowmourne);
                    break;
                case "Shards":
                    Console.WriteLine("{0} obtained!", LegendaryItem.Shadowmourne);
                    break;
                case "fragments":
                    Console.WriteLine("{0} obtained!", LegendaryItem.Valanyr);
                    break;
                case "Fragments":
                    Console.WriteLine("{0} obtained!", LegendaryItem.Valanyr);
                    break;
                case "motes":
                    Console.WriteLine("{0} obtained!", LegendaryItem.Dragonwrath);
                    break;
                case "Motes":
                    Console.WriteLine("{0} obtained!", LegendaryItem.Dragonwrath);
                    break;
                default:
                    break;
            }
        }
    }
}
