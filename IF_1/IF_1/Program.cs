using System;
namespace IF_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Адади бутун дода шудааст:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                ++a;
                Console.WriteLine($"Адади мусбат аст ва ба 1 вохид зиёд карда шуд. Натича: {a}"); ;
            }
            else
            {
                Console.WriteLine($"Адади мусбат нест!");
            }
        }
    }
}