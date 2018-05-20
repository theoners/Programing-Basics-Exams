using System;

namespace _06._Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char skipSymbol = char.Parse(Console.ReadLine());
            int counter = 0;

            for (char i = start; i <= end; i++)
            {
                for (char k = start; k <= end; k++)
                {
                    for (char l = start; l <= end; l++)
                    {
                        if (i!=skipSymbol && l!=skipSymbol && k!=skipSymbol)
                        {
                            counter++;
                            string result = "" + (char)i + (char)k + (char)l;
                            Console.Write(result);
                            Console.Write(" ");
                        }
                    }
                }
            }
            Console.Write(counter);
        }
    }
}
