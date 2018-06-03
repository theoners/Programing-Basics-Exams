using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        for (int l = 0; l < 10; l++)
                        {
                            for (int m = 0; m < 10; m++)
                            {
                                for (int p = 0; p < 10; p++)
                                {
                                    if (i*k*j*l*m*p==n)
                                    {
                                        Console.Write($"{i}{k}{j}{l}{m}{p} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
