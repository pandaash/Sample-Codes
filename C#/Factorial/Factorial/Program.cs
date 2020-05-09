using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            int n = Int32.Parse(Console.ReadLine());

            if (n >= 1 && n <= 15)
            {
                for (int i = n; i >= 2; i--)
                {
                    fact *= i;
                }
                Console.Write(fact);
                Console.ReadLine();
            }
        }
    }
}
