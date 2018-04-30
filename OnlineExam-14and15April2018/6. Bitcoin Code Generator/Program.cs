using System;

namespace _6._Bitcoin_Code_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSymbol = 33;
            int secondSymbol = 58;
            int fifthdSymbol = 58;
            int sixthSymbol = 33;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            long codeCount = long.Parse(Console.ReadLine());
            long count = 0;
            string result = "";

            for (int i = 1; i <= a; i++)
            {
                for (int k = 1; k <= b; k++)
                {
                    result = "" + (char)firstSymbol + (char)secondSymbol + i + k + (char)fifthdSymbol + (char)sixthSymbol;
                    Console.Write(result+"|");
                    count++;

                    if (firstSymbol==47)
                    {
                         firstSymbol = 33;
                         
                         sixthSymbol = 33;
                    }
                    else
                    {
                        firstSymbol++;

                        sixthSymbol++;
                    }
                    if (secondSymbol==64)
                    {
                        secondSymbol = 58;
                        fifthdSymbol = 58;
                    }
                    else
                    {
                        secondSymbol++;
                        fifthdSymbol++;
                    }
                    if (count==codeCount)
                    {
                        return;
                    }
                }
            }
        }

    }
}
