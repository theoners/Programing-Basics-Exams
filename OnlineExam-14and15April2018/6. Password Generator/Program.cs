using System;

namespace _6._Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = int.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine().ToUpper());
            char c = char.Parse(Console.ReadLine().ToLower());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            long n = long.Parse(Console.ReadLine());
            long count = 0;
            string result = "";

            for (int first = 1; first <= a; first++)
            {
                for (int second = 'A'; second <= b; second++)
                {
                    for (int third = 'a'; third <= c; third++)
                    {
                        for (int forth = 1; forth <= d; forth++)
                        {
                            for (int fifth = 1; fifth <= e; fifth++)
                            {
                                for (int sixth = 1; sixth <= f; sixth++)
                                {
                                    count++;

                                    if (n == count)
                                    {
                                        result = "" + first + (char)second + (char)third + forth + fifth+sixth;
                                        Console.WriteLine(result);
                                        break;
                                    }
                                }
                                
                            }
                        }
                    }
                }
            }
            if (count<n)
            {
                Console.WriteLine("No password on this position");
            }
            
        }
    }
}
