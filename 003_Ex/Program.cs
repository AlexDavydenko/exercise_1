using System;

namespace _003_Ex
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Выберите число от 1 до 12:");
            // Вводим первое число

            int choise1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Вы выбрали:{0}", choise1);

         


            switch (choise1)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Today is Winter.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Today is Spring.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Today is Summer.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Today is Autumn.");
                    break;
                   default:
                    Console.WriteLine("There are no such mounth.");
                    break;
            }
        }
    }
}
