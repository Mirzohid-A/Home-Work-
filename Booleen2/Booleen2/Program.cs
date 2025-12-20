using System;
namespace Boolean2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Адади бутун ро санчида бенед ток аст ё не!\nАдади а ро ворид намоед:");
            int a = Convert.ToInt32(Console.ReadLine());
            bool pr = a / 2 == 0;
            if (pr)
            {
                Console.Write($"Адади вориднамуда {pr} ток аст");
            }
            else
            {
                Console.Write($"Адади вориднамуда {pr} ток не!");
            }
        }
    }
}