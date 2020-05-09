using System;

namespace ConditionalAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            age = Int32.Parse(Console.ReadLine());

            if (age >= 1 && age < 10)
            {
                Console.Write("I am happy as having no responsibilities");
                Console.ReadLine();
            }
            else if (age >= 10 && age < 18)
            {
                Console.Write("I am still happy but starts feeling pressure of life");
                Console.ReadLine();
            }
            else if (age >= 18 && age <= 100)
            {
                Console.Write("I am very much happy as i handled the pressure very well");
                Console.ReadLine();
            }

        }
    }
}
