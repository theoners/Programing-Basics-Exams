using System;

namespace _02._Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double foodForDog = double.Parse(Console.ReadLine());
            double foodForCat = double.Parse(Console.ReadLine());
            double foodForTurtle = double.Parse(Console.ReadLine())/1000;

            double totalFood = (foodForCat+foodForDog+foodForTurtle)*days;

            if (food<totalFood)
            {
                Console.WriteLine($"{Math.Ceiling(totalFood-food)} more kilos of food are needed.");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(food-totalFood)} kilos of food left.");
            }
        }
    }
}
