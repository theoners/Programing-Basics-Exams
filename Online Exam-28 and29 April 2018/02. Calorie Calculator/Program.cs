using System;

namespace _02._Calorie_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender = Console.ReadLine();
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double age = double.Parse(Console.ReadLine());
            string activity = Console.ReadLine();
            double blm = 0;
            double factor = 0;

            if (gender =="m")
            {
                blm = 66 + (13.7 *weight) +(5 * height*100) -(6.8 * age);
            }
            else
            {
                blm = 655 + (9.6 * weight) + (1.8 * height * 100) - (4.7 * age);
            }

            switch (activity)
            {
                case "sedentary":
                    factor = 1.2;
                    break;
                case "lightly active":
                    factor = 1.375;
                    break;
                case "moderately active":
                    factor = 1.55;
                    break;
                case "very active":
                    factor = 1.725;
                    break;
                default:
                    break;
            }
            blm *= factor;

            Console.WriteLine($"To maintain your current weight you will need {Math.Ceiling(blm)} calories per day.");
        }
    }
}
