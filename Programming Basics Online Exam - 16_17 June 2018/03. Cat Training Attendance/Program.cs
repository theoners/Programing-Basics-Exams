using System;

namespace _03._Cat_Training_Attendance
{
    class Program
    {
        static void Main(string[] args)
        {
            double startTime = double.Parse(Console.ReadLine())*60;
            double enterHour = double.Parse(Console.ReadLine())*60;
            double enterMin = double.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();
            double points = 0;

            double enterTime = enterHour + enterMin;
            if (startTime>enterTime)
            {
                points += 1.5;
            }
            else if (enterTime-startTime<=30)
            {
                points += 1;
            }
            else 
            {
                points += 0.5; ;
            }

            if (dayOfWeek=="Monday" || dayOfWeek == "Wednesday" || dayOfWeek == "Friday")
            {
                points += 0.6;
            }
            else if (dayOfWeek == "Tuesday" || dayOfWeek == "Thursday" || dayOfWeek == "Saturday")
            {
                points += 0.8;
            }
            else if (dayOfWeek == "Sunday")
            {
                points += 2;
            }

            Console.WriteLine($"{points:F2}");
        }
    }
}
