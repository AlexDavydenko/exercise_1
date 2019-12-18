using System;

namespace _010_Ex
{
    class multiplication_table
    {
        static void Main()
        {
            Console.WriteLine("Введите число от одного до двадцати!");
            
            int choise1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Таблица умножения на " + choise1 + " такая:");
            for(int i = 1; i < 21; i++)
            {
                int rez;
                rez = i * choise1;
                Console.WriteLine(rez);
            }


            Console.ReadKey();
        }
    }
}
