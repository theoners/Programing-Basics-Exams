using System;

namespace _04.External_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentNumber = int.Parse(Console.ReadLine());
            double poorMarks = 0;
            double satisfactoryMarks = 0;
            double goodMarks = 0;
            double veryGoodMarks = 0;
            double excellentMarks = 0;

            for (int i = 0; i < studentNumber; i++)
            {
                double point = double.Parse(Console.ReadLine());

                if (point<=22.5)
                {
                    poorMarks++;
                }
                else if (point<=40.5)
                {
                    satisfactoryMarks++;
                }
                else if (point<=58.5)
                {
                    goodMarks++;
                }
                else if (point<=76.5)
                {
                    veryGoodMarks++;
                }
                else
                {
                    excellentMarks++;
                }
            }

            Console.WriteLine($"{(poorMarks*100/ studentNumber):F2}% poor marks");      
            Console.WriteLine($"{(satisfactoryMarks*100 /studentNumber):F2}% satisfactory marks");
            Console.WriteLine($"{(goodMarks*100 /studentNumber):F2}% good marks");
            Console.WriteLine($"{(veryGoodMarks*100 /studentNumber):F2}% very good marks");
            Console.WriteLine($"{(excellentMarks*100/ studentNumber):F2}% excellent marks");

        }
    }
}
