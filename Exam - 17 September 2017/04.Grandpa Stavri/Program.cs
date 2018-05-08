using System;

namespace _04.Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalRakia = 0;
            double totalDegrees = 0;

            for (int i = 0; i < days; i++)
            {
                double rakiaQuantity = double.Parse(Console.ReadLine());
                double rakiaDegrees = double.Parse(Console.ReadLine());

                totalRakia += rakiaQuantity;
                totalDegrees += rakiaQuantity * rakiaDegrees;
            }

            double degreesPerLitre = totalDegrees / totalRakia;
            Console.WriteLine($"Liter: {totalRakia:F2}");
            Console.WriteLine($"Degrees: {degreesPerLitre:F2}");
            if (degreesPerLitre<38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (degreesPerLitre>=38 && degreesPerLitre<=42)
            {
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
