using System;

namespace _008_EX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Делайте ставки господа!? ");



            int choise = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ставка: " + choise);

            Console.WriteLine("Бросаем кубик! .  .  .");

            //Создание объекта для генерации чисел
            Random rnd = new Random();

            //Получить очередное (в данном случае - первое) случайное число
            int value = rnd.Next(1,12);

            //Вывод полученного числа в консоль
            Console.WriteLine("Выпало: " + value);

            switch (value) {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Вы проиграли!");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Вы остались при своем!");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Вы удвоили Ваши деньги!");
                    break;
                case 12:
                    Console.WriteLine("Вы выиграли джекпот!!");
                    break;
                default:
                    Console.WriteLine("попробуйте еще раз!");
                    break;
            }
        }
    }
}
