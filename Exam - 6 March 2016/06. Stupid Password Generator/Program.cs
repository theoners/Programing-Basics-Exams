using System;

namespace _06._Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int k = 1;  k <= n;  k++)
                {
                    for (char m = 'a'; m < 'a'+l; m++)
                    {
                        for (char j = 'a'; j < 'a'+l; j++)
                        {
                            for (int p = 1; p <= n; p++)
                            {
                                if (p>i && p>k)
                                {
                                    Console.Write($"{i}{k}{m}{j}{p} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
