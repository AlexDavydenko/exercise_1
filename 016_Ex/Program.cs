using System;

namespace _016_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "root", inpt = string.Empty;
            while (password != inpt)
            {
                Console.Write("Введите пароль для входа! ");
                inpt = string.Empty;
                while (true)
                {
                    var key = Console.ReadKey(true);//не отображаем клавишу - true

                    if (key.Key == ConsoleKey.Enter) break; //enter - выходим из цикла

                    Console.Write("*");//рисуем звезду вместо нее
                    inpt += key.KeyChar; //копим в пароль символы
                }
                Console.WriteLine();
            }
            Console.Write("Допуск получен!");
            Console.ReadKey();

        }
    }
}
