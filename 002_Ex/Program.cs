using System;

namespace MyApplication 
{
    class Program
{
    static void Main()
    {
        //Гавкните или мяукните

         Console.WriteLine("Нажмите \"1\" если хотите гавкнуть и \"2\" если мяукнуть:");

          // Create a string variable and get user input from the keyboard and store it in the variable
         
            int choise = Convert.ToInt32(Console.ReadLine());
            int Wou = 1;
            //int Mau = 2;
            if (choise == Wou)
            {
                Console.WriteLine("Напои валерьянкой собаку!");
            }
            else if(choise == 2)
            {
                Console.WriteLine("Выгуляй хорошенько кота!");
            }
            else
            {
                Console.WriteLine("Лучше заведи себе питомца!");
            }
        }
    }
}

