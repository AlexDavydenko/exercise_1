using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 15;
            if (b < a)
            {
                Console.WriteLine(a + " больше " + b);
            }
            else
            {
                Console.WriteLine(b + " больше " + a);
            }
        }
    }
}
