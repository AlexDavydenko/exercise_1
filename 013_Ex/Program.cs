using System;

namespace _013_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пять целых чисел");
            int choise1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Первое число - " + choise1);
            int choise2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число - " + choise2);
            int choise3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Третье число - " + choise3);
            int choise4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Четвертое число - " + choise4);
            int choise5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Пятое число - " + choise5);
            int result = 0;
            result = (choise1 + choise2 + choise3 + choise4 + choise5) / 5;
            Console.WriteLine("Среднее арфметическое от этих чисел - " + result);
        
        }
    }
}
