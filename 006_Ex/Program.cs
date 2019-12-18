using System;

namespace _006_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для расчета стоимости поездки введите количество киллометров: ");
            // Вводим киллометраж

            int choise1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Количество минут простоя: ");
           
            // Вводим простой

            int choise2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Киллометраж:{0} км", choise1);
            Console.WriteLine("Простой:{0} мин", choise2);

            int valueOfTrip = 0;
            // decimal oneKM = 3.00;
            if (choise1 == 0)
            {
                Console.WriteLine("Не хотите не едьте!");
            }
            else if (choise1 <= 5)
            {
                valueOfTrip = 20 + choise2;
            }
            else if (choise1 > 5)
            {
                valueOfTrip = ((choise1 - 5) * 3) + 20 + choise2;
            }
           Console.WriteLine("Стоимость проезда :" + valueOfTrip);
        }
    }
}
