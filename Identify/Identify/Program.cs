using System;

namespace Identify
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            s = Console.ReadLine();
            int start=System.DateTime.Now.Millisecond;

            bool a = int.TryParse(s, out int result);
            bool b = float.TryParse( s, out float result1);
            bool c = IsString(s);

            if (a == true)
                Console.WriteLine("This input is of type Integer");
            else if (b == true)
                Console.WriteLine("This input is of type Float");
            else if (c == true)
                Console.WriteLine("This input is of type string");
            else
                Console.Write("This is something else");
            Console.WriteLine(System.DateTime.Now.Millisecond - start + "ms");
            Console.ReadLine();
        }
        static bool IsString(string s)
        {
            int flag = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]) == true)
                    flag++;
            }
            if (flag == s.Length)
                return true;
            else
                return false;
        }
    }
}
