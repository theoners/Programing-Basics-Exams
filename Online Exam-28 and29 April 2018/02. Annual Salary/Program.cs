using System;

namespace _02._Annual_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            double exprerience = double.Parse(Console.ReadLine());
            string profession = Console.ReadLine();
            double salary = 0;

                switch (profession)
                {
                    case "C# Developer":
                        salary = 5400;
                        break;
                    case "Java Developer":
                        salary = 5700;
                        break;
                    case "Front-End Web Developer":
                        salary = 4100;
                        break;
                    case "UX / UI Designer":
                        salary = 3100;
                        break;
                    case "Game Designer":
                        salary = 3600;
                        break;
                }
            if (exprerience>5)
            {
                Console.WriteLine($"Total earned money: {(salary*12):F2} BGN");
            }
            else
            {
                salary = salary * 0.342;
                Console.WriteLine($"Total earned money: {(salary * 12):F2} BGN");
            }
        }
    }
}
