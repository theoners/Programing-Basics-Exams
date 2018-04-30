using System;

namespace _5._Skyscraper
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
           

            for (int i = 0; i < number-3; i++)
            {
                for (int k = 0; k < number; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|",+2);
            }
            string line = new string(' ',number-1);
            Console.WriteLine(line+"_|_");

            for (int i = 0; i < number - 3; i++)
            {
                for (int k = 0; k < number-1; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|-|");
            }
            line = new string(' ', number - 2);
            Console.WriteLine(line+"_|-|_");

            for (int i = 0; i < number-3; i++)
            {
                for (int k = 0; k < number-2; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|***|");
            }
            line = new string('_', number-3);
            Console.WriteLine(" "+line+"|***|"+line);

            for (int i = 0; i < number*4-1; i++)
            {
                line = new string('|', number - 2);
                Console.WriteLine(" "+line+"---"+line);
                    
            }

            Console.WriteLine("_"+line+"---"+line+"_");

            line = new string('|',2*number+1);
            for (int i = 0; i < number-2; i++)
            {
                Console.WriteLine(line);
            }
        }
    }
}
