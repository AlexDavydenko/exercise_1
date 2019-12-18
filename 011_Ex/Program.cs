using System;

namespace _011_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            //Получить очередное (в данном случае - первое) случайное число
            int value = rnd.Next(1, 146);

            //Вывод полученного числа в консоль
            Console.WriteLine("Угадай число от 1 до 146!");

            int i = 0;
            do
            {
                int choise1 = Convert.ToInt32(Console.ReadLine());

            
                if (value > choise1)
                {

                    Console.WriteLine("Больше!");


                }
                else if (value < choise1)
                {

                    Console.WriteLine("Меньше!");
                    
                }
                else
                {

                    Console.WriteLine("Угадал!");
                    i = 3;

                }
            }
            while (i < 3);
            Console.ReadKey();
        }
    }
}
