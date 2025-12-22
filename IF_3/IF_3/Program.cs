using System;
namespace IF_3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Адади бутун дода шудааст: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                number += 1;
                Console.WriteLine($"Адади мусбат аст ва ба 1 - вохид зиёд шуд {number}");
            } else if (number < 0)
            {
                number -= 2;
                Console.WriteLine($"Адади манфи аст ва аз 2 - вохид кам шуд {number}");
            }
            else if(number == 0)
            {
                number = 10;
                Console.WriteLine($"Адади сифр аст ва ба 10 - вохид иваз шуд {number}");
            }
            else
            {
                Console.WriteLine("Нодуруст танхо адад навишта мешавад");
            }
            {

            }
        }
    }
}