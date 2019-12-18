using System;

namespace _014_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Машина придумает пять целых чисел!");
            Random ran1 = new Random();
            int value1 = ran1.Next(1, 10000000);
            Console.WriteLine("Первое число " + value1);

            //Random ran2 = new Random();
            int value2 = ran1.Next(1, 10000000);
            Console.WriteLine("Первое число " + value2);

           // Random ran3 = new Random();
            int value3 = ran1.Next(1, 10000000);
            Console.WriteLine("Первое число " + value3);

            //Random ran4 = new Random();
            int value4= ran1.Next(1, 10000000);
            Console.WriteLine("Первое число " + value4);

           // Random ran5 = new Random();
            int value5 = ran1.Next(1, 10000000);
            Console.WriteLine("Первое число " + value5);

            int result = 0;
            result = (value1 + value2 + value3 + value4 + value5) / 5;
            Console.WriteLine("Среднее арфметическое от этих чисел - " + result);
        }
    }
}
