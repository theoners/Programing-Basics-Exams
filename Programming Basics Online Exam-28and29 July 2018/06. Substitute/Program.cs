using System;

namespace _06._Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string firstNumber="";
            string secondNumber="";
            int counter = 0;

            for (int i = k; i < 9; i++)
            {
                for (int j = 9; j >= l; j--)
                {
                    firstNumber =""+ i + j;

                    for (int s = m; s < 9; s++)
                    {
                        for (int t = 9; t >= n; t--)
                        {
                            secondNumber = ""+s + t;

                            if (i%2==0 && j%2==1 && s%2==0 && t%2==1)
                            {
                                if (firstNumber==secondNumber)
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                }
                                else
                                {
                                    Console.WriteLine($"{firstNumber} - {secondNumber}");
                                    counter++;
                                    if (counter==6)
                                    {
                                        return;
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
