using System;

namespace _01._Cat_Diet
{
    class Program
    {
        static void Main(string[] args)
        {
            double percentFats = double.Parse(Console.ReadLine())/100;
            double percentProteins = double.Parse(Console.ReadLine())/100;
            double percentCarbohydrates = double.Parse(Console.ReadLine())/100;
            double totalCalories = double.Parse(Console.ReadLine());
            double percentWater = double.Parse(Console.ReadLine())/100;

            double totalFats = (percentFats*totalCalories)/ 9;
            double totalProteins = (percentProteins * totalCalories) / 4;
            double totalCarbohydrates = (percentCarbohydrates * totalCalories) / 4;
            double totalNeto = totalFats + totalProteins + totalCarbohydrates;
            double caloriesInOneGram = totalCalories / totalNeto;
            caloriesInOneGram = caloriesInOneGram * (1-percentWater);

            Console.WriteLine($"{caloriesInOneGram:F4}");
        }
    }
}
