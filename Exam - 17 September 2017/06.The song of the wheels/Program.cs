using System;
using System.Collections.Generic;

namespace _06.The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int count = 0;
            string password = "No!";
            var list = new List<string>();

            for (int a = 1; a < 10; a++)
            {
                for (int b = 1; b < 10; b++)
                {
                    for (int c = 1; c < 10; c++)
                    {
                        for (int d = 1; d < 10; d++)
                        {
                            if (a*b+c*d ==m && a<b && c>d)
                            {
                                list.Add("" + a + b + c + d);
                                count++;
                                if (count==4)
                                {
                                    password = "" + a + b + c + d;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ",list));

            if (password=="No!")
            {
                Console.Write(password);
            }
            else
            {
                Console.Write($"Password: {password}");
            }
        }
    }
}
