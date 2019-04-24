using System;

namespace SimpleInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            double s = Math.Round((a * b * c) / 100);
            Console.Write(s);
            Console.ReadLine();
        }
    }
}
