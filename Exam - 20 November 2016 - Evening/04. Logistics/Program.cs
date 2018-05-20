using System;

namespace _04._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLoad = int.Parse(Console.ReadLine());
            double busLoad = 0;
            double truckLoad = 0;
            double trainLoad = 0;

            for (int i = 0; i < numberOfLoad; i++)
            {
                double load = int.Parse(Console.ReadLine());

                if (load<=3)
                {
                    busLoad += load;
                }
                else if (load<=11)
                {
                    truckLoad += load;
                }
                else
                {
                    trainLoad += load;
                }
            }

            double totalLoad = busLoad + trainLoad + truckLoad;
            double averagePrice = (busLoad * 200 + truckLoad * 175 + trainLoad * 120)/totalLoad;

            Console.WriteLine($"{averagePrice:F2}");
            Console.WriteLine($"{((busLoad/totalLoad)*100):F2}%");
            Console.WriteLine($"{((truckLoad/totalLoad)*100):F2}%");
            Console.WriteLine($"{((trainLoad/totalLoad)*100):F2}%");
        }
    }
}
