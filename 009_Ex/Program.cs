using System;

namespace _009_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; 
            while (i < 4) 
            {
                Console.WriteLine("Выберте валюту, которую Вы хотите обченять!");
                Console.WriteLine("1 - гривна, 2 - евро, 3 - Доллары, 4 - нечего больше менять");

                int choise1 = Convert.ToInt32(Console.ReadLine());
                i = choise1;
                if (choise1 < 4)
                {
                    switch (choise1)
                    {
                        case 1:
                            Console.WriteLine("Базовая валюта - гривна");
                            break;
                        case 2:
                            Console.WriteLine("Базовая валюта - Евро");
                            break;
                        case 3:
                            Console.WriteLine("Базовая валюта - Доллар");
                            break;
                        default:
                            Console.WriteLine("Выберите валюту!");
                            break;

                    }
                    Console.WriteLine("Введите количество базовой валюты!");

                    double choise2 = Convert.ToDouble(Console.ReadLine());
                    double gr_eu = 27.5;
                    double gr_dol = 23.5;
                    if (choise1 == 1)
                    {
                        Console.WriteLine(choise2 + " гривень это: ");
                        Console.Write(choise2 / gr_eu + "евро,  и ");
                        Console.Write(choise2 / gr_dol + " евро");
                    }
                    else if (choise1 == 2)
                    {
                        Console.WriteLine(choise2 + " евро это: ");
                        Console.Write((gr_eu / gr_dol) * choise2 + "долларов, и  ");
                        Console.Write(choise2 * gr_eu + " гривень");
                    }
                    else
                    {
                        Console.WriteLine(choise2 + " долларов это: ");
                        Console.Write((gr_dol / gr_eu) * choise2 + "евро, и  ");
                        Console.Write(choise2 * gr_dol + " гривень");
                    }

                }
                else
                    continue;
            }
            Console.WriteLine("До свиданья!" );
            Console.ReadKey();
        }

    }
}
