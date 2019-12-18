using System;

namespace _005_Ex
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Выберите число от 1 до 7:");
            // Вводим число

            int choise1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Вы выбрали:{0}", choise1); 
            switch (choise1)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("от одного до семи!!!");
                    break;
            }
        }
    }
}

