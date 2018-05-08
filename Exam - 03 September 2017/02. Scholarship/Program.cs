using System;

namespace _02._Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grades = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            if (income>minSalary && grades<5.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
                
            }
            else if (income <= minSalary && grades < 4.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income<=minSalary && grades>=4.50 && grades<5.50)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor( minSalary*0.35)} BGN");
            }
            else if(income > minSalary && grades >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results { Math.Floor(grades*25)} BGN");
            }
            else if(income <= minSalary && grades >= 5.50)
            {
                if (minSalary * 0.35> grades * 25)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(minSalary * 0.35)} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results { Math.Floor(grades * 25)} BGN");
                }
            }
        }
    }
}
