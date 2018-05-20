using System;

namespace _04._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            double topStudents = 0;
            double between4and5 = 0;
            double between3and4 = 0;
            double fail = 0;
            double totalGrade = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade <= 2.99)
                {
                    fail++;
                }
                else if (grade<4)
                {
                    between3and4++;
                }
                else if (grade<5)
                {
                    between4and5++;
                }
                else
                {
                    topStudents++;
                }
                totalGrade += grade;
            }

            double averageGrade = totalGrade / numberOfStudents;

            Console.WriteLine($"Top students: {((topStudents/numberOfStudents)*100):F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {((between4and5/numberOfStudents)*100):F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {((between3and4/numberOfStudents)*100):F2}%");
            Console.WriteLine($"Fail: {((fail/numberOfStudents)*100):F2}%");
            Console.WriteLine($"Average: {averageGrade:F2}");
        }
    }
}
