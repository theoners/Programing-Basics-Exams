using System;

namespace _04._Energy_Loss
{
    class Program
    {
        static void Main(string[] args)
        {
            double trainingDays = double.Parse(Console.ReadLine());
            double dancer = double.Parse(Console.ReadLine());
            int energy = 0;

            for (int i = 1; i <=trainingDays; i++)
            {
                int hours = int.Parse(Console.ReadLine());

                if (i%2==0 && hours%2==0)
                {
                    energy += 68;
                }
                else if (i % 2 == 1 && hours % 2 == 0)
                {
                    energy += 49;
                }
                else if (i % 2 == 0 && hours % 2 == 1)
                {
                    energy += 65;
                }
                else if (i % 2 == 1 && hours % 2 == 1)
                {
                    energy += 30;
                }
            }

            double leftEnergy = trainingDays * 100 - energy;
            double leftEnergyPerDancer = leftEnergy / trainingDays;

            if (leftEnergyPerDancer>50)
            {
                Console.WriteLine($"They feel good! Energy left: {leftEnergyPerDancer:F2}");
            }
            else
            {
                Console.WriteLine($"They are wasted! Energy left: {leftEnergyPerDancer:F2}");
            }
        }
    }
}
