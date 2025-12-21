using System;
namespace Boolean30
{
    class Program
    {
        static void Main()
        {
            Console.Write("Адади a,b,c дода шуддаст, ки тарафхояш баробар аст ё не санчида шавад \nАдади а - ро дохил намоед:");
            int a = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Адади b - ро дохил намоед:");
            int b = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Адади c - ро дохил намоед:");
            int c = Convert.ToInt32 (Console.ReadLine());
            string[] bar = { "баробар", "набаробар" };  
            bool rs = a == b && b == c && c == a;
            if (rs)
            {
                Console.WriteLine($"Тарафхои секунча {bar[0]} аст: {rs}");
            }
            else if (!rs)
            {
                Console.WriteLine($"Тарафхои секунча {bar[1]} аст: {rs}");
            }
        }
    }
}