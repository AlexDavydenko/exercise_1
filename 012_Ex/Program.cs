using System;

namespace _012_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число до 100!");
            double choise1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Так значит Вам интересно узнать все квадраты чисел до " + choise1 + "!?");
            Console.ReadKey();

            for (int i = 1; i < choise1; i++)
                Console.WriteLine(i*i);
        }

    
    }
}
