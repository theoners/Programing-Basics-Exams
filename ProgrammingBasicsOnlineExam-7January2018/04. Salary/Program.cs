using System;

namespace _04._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = double.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            string member = Console.ReadLine();

            for (int i = 1; i < 100; i++)
            {
                salary *= 1.06;
                if (i%5==0)
                {
                    salary += 100;
                }
                if (i % 10 == 0)
                {
                    salary += 100;
                }
                if (member=="Yes"&& (i % 5 !=0 ||i % 10 == 0))
                {
                    salary *= 0.99; ;
                }
                if (salary<=5000 && i ==years)
                {
                    Console.WriteLine($"Current salary: {salary:F2}");
                }
                if (salary>=5000 && i>years)
                {
                    Console.WriteLine($"{i-years-1} more years to max salary.");
                    return;
                }
                if (salary>=5000 && i <=years)
                {
                    Console.WriteLine($"Current salary: 5000.00");
                    Console.WriteLine("0 more years to max salary.");
                    return;
                }
            }
        }
    }
}
