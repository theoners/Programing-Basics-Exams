using System;

namespace _04___Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int lecture = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double salary = budget / lecture;
            int lectureJelev = 0;
            int lectureRoYaL = 0;
            int lectureRoli = 0;
            int lectureTrofon = 0;
            int lectureSino = 0;
            int lectureOthers = 0;
            for (int i = 0; i < lecture; i++)
            {
                string lecturer = Console.ReadLine();
                switch (lecturer)
                {
                    case "Jelev":
                        lectureJelev++;
                        break;
                    case "RoYaL":
                        lectureRoYaL++;
                        break;
                    case "Roli":
                        lectureRoli++;
                        break;
                    case "Trofon":
                        lectureTrofon++;
                        break;
                    case "Sino":
                        lectureSino++;
                        break;
                    default:
                        lectureOthers++;
                        break;
                }
            }
            Console.WriteLine($"Jelev salary: {(salary * lectureJelev):F2} lv");
            Console.WriteLine($"RoYaL salary: {(salary * lectureRoYaL):F2} lv");
            Console.WriteLine($"Roli salary: {(salary * lectureRoli):F2} lv");
            Console.WriteLine($"Trofon salary: {(salary * lectureTrofon):F2} lv");
            Console.WriteLine($"Sino salary: {(salary * lectureSino):F2} lv");
            Console.WriteLine($"Others salary: {(salary * lectureOthers):F2} lv");
        }
    }
}
