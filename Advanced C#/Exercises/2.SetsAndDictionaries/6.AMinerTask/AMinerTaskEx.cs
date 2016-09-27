namespace _6.AMinerTask
{
    using System;
    using System.Collections.Generic;

    public class AMinerTaskEx
    {
        public static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            long quantity = long.Parse(Console.ReadLine());
            Dictionary<string, double> resources = new Dictionary<string, double>();
            
            while(resource != "stop")
            {
                if(!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }
               
                resources[resource] += quantity;
                
                resource = Console.ReadLine();
                if(resource != "stop")
                {
                    quantity = long.Parse(Console.ReadLine());
                }                
            }

            foreach(var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
