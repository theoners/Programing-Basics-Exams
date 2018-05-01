using System;

namespace _06._Bank_Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            char d = char.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int passwordCount = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = a; i < 100; i++)
            {
                for (int k = b; k <='Z'; k++)
                {
                    for (int j = c; j <='z'; j++)
                    {
                        for (int l = d; l <= 'Z'; l++)
                        {
                            for (int m = e; m >=10; m--)
                            {
                                if (i%10==2 && m%10==5)
                                {
                                    count++;
                                    if (count==passwordCount)
                                    {
                                        Console.WriteLine(""+i+(char)k+ (char)j + (char)l +m);
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
