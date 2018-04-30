using System;

namespace _06._Special_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = 2; i <= first; i++)
            {
                if (i%2==0)
                {
                    for (int k = 2; k <= second; k++)
                    {
                        if (k==2||k==3||k==5||k==7)
                        {
                            for (int j = 2; j <= third; j++)
                            {
                                if (j % 2 == 0)
                                {
                                    result =""+ i + " " + k + " " + j;
                                    Console.WriteLine(result);
                                }
                            }
                        }
                    }
                }
                
            }
        }
    }
}
