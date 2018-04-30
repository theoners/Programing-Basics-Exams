using System;

namespace _5._Marguerita
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string line = new string('\'',8*number-1);
            Console.WriteLine("'&$"+line);

            for (int i = 0; i < number-1; i++)
            {
                for (int k = 0; k < 2+i; k++)
                {
                    Console.Write("'");
                }
                line = new string('\'',8*number-1-i);
                Console.WriteLine("\\"+line);
            }
            for (int i = 0; i < number*4; i++)
            {
                Console.Write("^*");
            }
            Console.WriteLine("^'");

            for (int i = 0; i < number-1; i++)
            {
                
                for (int k = 0; k < i; k++)
                {
                    Console.Write("'");
                }
                Console.Write("\\\\");
                line = new string(' ', number);
                Console.Write(line+"\\");
                for (int j = 0; j < 7*number-4-2*i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("//");
                for (int l = 0; l < i+1; l++)
                {
                    Console.Write("'");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < number-1; i++)
            {
                Console.Write("'");
            }
            
            line = new string('~',6*number+1);
            Console.Write("\\"+line+"/");
            line = new string('\'',number);
            Console.WriteLine(line);

            for (int i = 0; i < number -2; i++)
            {
                for (int k = 0; k < number+i; k++)
                {
                    Console.Write("'");
                }
                Console.Write("\\");

                for (int k = 0; k < 6*number-1-i*2; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("/");
                for (int k = 0; k < number+1 + i; k++)
                {
                    Console.Write("'");
                }
                Console.WriteLine();

                
            }
            Console.Write(new string('\'', number * 2 - 2));
            Console.Write("\\");
            Console.Write(new string('_',number*4+3));
            Console.Write("/");
            Console.Write(new string('\'', number * 2 - 1));
            Console.WriteLine();

            Console.Write(new string('\'', number * 2 - 1));
            Console.Write("\\");
            Console.Write(new string('.', number * 4 + 1));
            Console.Write("/");
            Console.Write(new string('\'', number * 2 ));
            Console.WriteLine();

            for (int i = 0; i < number*2-1; i++)
            {
                Console.Write(new string('\'', number * 2+i ));
                Console.Write("\\");
                if (i!= number * 2 - 2)
                {
                    Console.Write(new string(' ', number * 4 - i * 2 - 1));
                }
                else
                {
                    Console.Write(new string('_', number * 4 - i * 2 - 1));
                }
                
                Console.Write("/");
                Console.Write(new string('\'', number * 2+i+1));
                Console.WriteLine();
            }

            for (int i = 0; i < number*2+1; i++)
            {
                Console.Write(new string('\'',(8*number-2)/2));
                Console.Write("|||");
                Console.Write(new string('\'', (8 * number - 2) / 2+1));
                Console.WriteLine();
            }
            Console.WriteLine(new string('_',8*number+1)+"'");
            Console.WriteLine("'"+new string('-', 8 * number - 1) + "''");
        }
    }
}
