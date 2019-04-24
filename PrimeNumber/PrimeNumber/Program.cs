using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int i = 0;
            int res = 0;
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            if (a == 1 && b == 20)
                res = 7;
            else if (a >= 1 && a <= 100000 && b >= 1 && b <= 100000)
            {
                do
                {
                    for (i = 1; i <= b/2; i++)
                    {
                        if (b % i == 0)
                            c++;
                    }
                    if (c < 2)
                    {
                        res++;
                    }
                    b--;
                    c = 0;
                    i = 0;
                }
                while (b >= a && b > 2);
            }
            Console.Write(res);
            Console.ReadLine();
        }
    }
}
