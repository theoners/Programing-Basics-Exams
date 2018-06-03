using System;

namespace _03._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMin = int.Parse(Console.ReadLine());

            int examTime = examHour * 60+examMin;
            int arriveTime = arriveHour * 60 + arriveMin;

            if (arriveTime>examTime)
            {
                Console.WriteLine($"Late");
                if (arriveTime-examTime<60)
                {
                    
                    Console.WriteLine($"{(arriveTime - examTime)} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{(arriveTime - examTime)/60}:{((arriveTime - examTime)%60):D2} hours after the start");
                }
            }
            else if(arriveTime <= examTime && examTime-arriveTime<=30)
            {
                Console.WriteLine("On time");

                if (arriveTime!=examTime)
                {
                    Console.WriteLine($"{(examTime-arriveTime)} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Early");
                if (examTime - arriveTime < 60)
                {
                    Console.WriteLine($"{(examTime - arriveTime)} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{(examTime - arriveTime)/60}:{((examTime - arriveTime) % 60):D2} hours before the start");
                }
            }
        }
    }
}
