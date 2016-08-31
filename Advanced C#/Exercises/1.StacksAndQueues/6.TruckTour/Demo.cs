using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.TruckTour
{
    public class Demo
    {
        public static void Main(string[] args)
        {
            int petrolPumpsNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            Queue<uint[]> pumps = new Queue<uint[]>();
            while (counter < petrolPumpsNumber)
            {
                string[] pumpInfoInput = 
                    Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                uint[] pumpInfo = Array.ConvertAll(pumpInfoInput, element => uint.Parse(element));

                pumps.Enqueue(pumpInfo);
                counter++;
            }

            uint currentAmountOfPetrol = 0;
            uint[] currentPump;
            int firstPumpPosition = 0;

            for (int i = 1; i <= petrolPumpsNumber; i++)
            {
                firstPumpPosition = i;
                currentPump = pumps.Dequeue();
                int numberOfVisitedPumps = 0;

                while (numberOfVisitedPumps < petrolPumpsNumber - 1)
                {
                    uint amountOfPetrolInCurrentPump = currentPump[0];
                    uint distanceFromCurrentToNextPump = currentPump[1];

                    currentAmountOfPetrol += amountOfPetrolInCurrentPump;
                    if (currentAmountOfPetrol < distanceFromCurrentToNextPump)
                    {
                        pumps.Enqueue(currentPump);

                        break;
                    }

                    pumps.Enqueue(currentPump);
                    numberOfVisitedPumps++;
                    currentPump = pumps.Dequeue();
                }
            }

            Console.WriteLine(firstPumpPosition);
        }
    }
}
