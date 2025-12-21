using System;
namespace Boolean6
{
    class Program
    {
        static void Main()
        {
            Console.Write("Се ададхои бутун дода шудааст a, b , c. Дурусти гуфтори он Нобаробарии дукаратаи a < b < c дуруст аст санчида мебиним \nАдади a - ро ворид намоед:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Адади b - ро ворид намоед:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Адади c - ро ворид намоед:");
            int c = Convert.ToInt32(Console.ReadLine());
            bool testing = a < b && b < c;
            Console.WriteLine($"Адади ворид намудаи шумо a = {a} b = {b} c = {c}; = {testing}");
        }
    }
}