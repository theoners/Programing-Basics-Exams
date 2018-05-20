using System;

namespace _04._SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            double totalMembers = 0;
            int car = 0;
            int microbus = 0;
            int minibus = 0;
            int bus = 0;
            int train = 0;

            for (int i = 0; i < groups; i++)
            {
                int groupMembers = int.Parse(Console.ReadLine());
                totalMembers += groupMembers;
                if (groupMembers<=5)
                {
                    car += groupMembers;
                }
                else if (groupMembers<=12)
                {
                    microbus += groupMembers;
                }
                else if (groupMembers<=25)
                {
                    minibus += groupMembers;
                }
                else if (groupMembers<=40)
                {
                    bus += groupMembers;
                }
                else
                {
                    train += groupMembers;
                }
            }

            Console.WriteLine($"{((car/totalMembers)*100):F2}%");
            Console.WriteLine($"{((microbus/totalMembers)*100):F2}%");
            Console.WriteLine($"{((minibus/totalMembers)*100):F2}%");
            Console.WriteLine($"{((bus/totalMembers)*100):F2}%");
            Console.WriteLine($"{((train/totalMembers)*100):F2}%");
        }
    }
}
