using System;

namespace _03._Online_Education
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int online = 0;
            int onsite = 0;

            for (int i = 0; i < 3; i++)
            {
               string educationType = Console.ReadLine();
                int student = int.Parse(Console.ReadLine());

                if (educationType=="online")
                {
                    online += student;
                }
                else
                {
                    onsite += student;
                }
                
            }

            if (onsite<=600)
            {
                Console.WriteLine($"Online students: {online}");
                Console.WriteLine($"Onsite students: {onsite}");
                Console.WriteLine($"Total students: {online+onsite}");
            }
            else
            {
                Console.WriteLine($"Online students: {online - 600 + onsite}");
                Console.WriteLine($"Onsite students: 600");
                Console.WriteLine($"Total students: {online + onsite}");
            }
        }
    }
}
