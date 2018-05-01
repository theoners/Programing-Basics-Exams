using System;

namespace _06._Sum_And_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n%10==5|| n % 3 == 0)
            {
                for (int a = 1; a <10; a++)
                {
                    for (int b = 9; b >= 1; b--)
                    {
                        for (int c = 0; c < 10; c++)
                        {
                            for (int d = 9; d >= c; d--)
                            {
                                if (a+b+c+d==a*b*c*d && n % 10 == 5)
                                {
                                    Console.WriteLine(""+a+b+c+d);
                                    return;
                                }
                                else if ((a * b * c * d)/(a + b + c + d) ==3  && n % 3 == 0)
                                {
                                    Console.WriteLine("" + d + c + b + a);
                                    return;
                                }
                            }
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("Nothing found");
            }
        }
    }
}
