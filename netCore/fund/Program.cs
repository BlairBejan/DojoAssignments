using System;

namespace fund
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 256; i++)
            {
            Console.WriteLine(i);
            }
            for (int i = 0; i < 101; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
            }
        }
    }
}
