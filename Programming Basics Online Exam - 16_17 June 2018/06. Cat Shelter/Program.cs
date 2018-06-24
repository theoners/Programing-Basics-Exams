using System;

namespace _06._Cat_Shelter
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalFood = double.Parse(Console.ReadLine())*1000;

            string input = Console.ReadLine();

            while (input!="Adopted")
            {
                int food = int.Parse(input);

                totalFood -= food;
                 input = Console.ReadLine();
            }

            if (totalFood>=0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {totalFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(totalFood)} grams more.");
            }

        }
    }
}
