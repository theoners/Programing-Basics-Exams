using System;

namespace _04___Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());
            double result = 0;
            double from0to9 = 0;
            double from10to19 = 0;
            double from20to29 = 0;
            double from30to39 = 0;
            double from40to50 = 0;
            double invalidNumber = 0;

            for (int i = 0; i < moves; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number<0 || number>50)
                {
                    invalidNumber++;
                    result /= 2;
                }
                else if (number< 10)
                {
                    from0to9++;
                    result +=number*0.2;
                }
                else if (number < 20)
                {
                    from10to19++;
                    result += number * 0.3;
                }
                else if (number < 30)
                {
                    from20to29++;
                    result += number * 0.4;
                }
                else if (number < 40)
                {
                    from30to39++;
                    result += 50;
                }
                else if (number <= 50)
                {
                    from40to50++;
                    result += 100;
                }
            }

            Console.WriteLine($"{result:F2}");
            Console.WriteLine($"From 0 to 9: {((from0to9/moves)*100):F2}%");
            Console.WriteLine($"From 10 to 19: {((from10to19/moves)*100):F2}%");
            Console.WriteLine($"From 20 to 29: {((from20to29/moves)*100):F2}%");
            Console.WriteLine($"From 30 to 39: {((from30to39/moves)*100):F2}%");
            Console.WriteLine($"From 40 to 50: {((from40to50/moves)*100):F2}%");
            Console.WriteLine($"Invalid numbers: {((invalidNumber/moves)*100):F2}%");
        }
    }
}
