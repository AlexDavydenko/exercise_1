using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите любое натуральное число:");
            // Вводим первое число
            
            int choise1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Вы выбрали:{0}", choise1);
            Console.WriteLine("Выберите еще одно натуральное число:");

            // Вводим второе число
            int choise2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Вы выбрали:{0}", choise2);
            
            if (choise2 > choise1)
            {
                Console.WriteLine(choise2 + " больше " + choise1);
            }
            else
            {
                Console.WriteLine(choise1 + " больше " + choise2);
            }
        }
    }
}
