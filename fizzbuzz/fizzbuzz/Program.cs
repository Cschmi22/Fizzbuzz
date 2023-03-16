using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            for (int i = 0; i < 100; i++)
            {
                num = i;
                if (num % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                if (num % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                Console.WriteLine(i);
            }

        }
    }
}