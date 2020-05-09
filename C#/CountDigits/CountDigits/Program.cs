using System;

namespace CountDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int n = Int32.Parse(Console.ReadLine());
            while (n != 0)
            {
                n = n / 10;
                c++;
            }
            if (c >= 1 && c <= 18)
            {
                Console.Write(c);
                Console.ReadLine();
            }
        }
    }
}
