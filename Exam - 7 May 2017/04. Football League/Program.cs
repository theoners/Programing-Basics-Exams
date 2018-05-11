using System;

namespace _04._Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            double stadionCapacity = double.Parse(Console.ReadLine());
            double numberOfFans = double.Parse(Console.ReadLine());
            int sectorA = 0;
            int sectorB = 0;
            int sectorV = 0;
            int sectorG = 0;

            for (int i = 0; i < numberOfFans; i++)
            {
                string sector = Console.ReadLine();

                switch (sector)
                {
                    case "A":
                        sectorA++;
                        break;
                    case "B":
                        sectorB++;
                        break;
                    case "V":
                        sectorV++;
                        break;
                    case "G":
                        sectorG++;
                        break;
                }
            }

            Console.WriteLine($"{((sectorA/numberOfFans)*100):F2}%");
            Console.WriteLine($"{((sectorB/numberOfFans)*100):F2}%");
            Console.WriteLine($"{((sectorV/numberOfFans)*100):F2}%");
            Console.WriteLine($"{((sectorG/numberOfFans)*100):F2}%");
            Console.WriteLine($"{((numberOfFans / stadionCapacity) * 100):F2}%");
        }
    }
}
