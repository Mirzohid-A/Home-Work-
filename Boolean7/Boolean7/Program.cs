using System;
namespace Boolean7
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Се ададҳои бутуни a, b, c дода шудаанд. Дурустии гуфтори: \r\n«Адади b дар байни ададҳои a ва c ҷойгир аст» санҷида мебинем.\nАдади a- ро ворид намоед:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Адади b - ро ворид намоед: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Адади c - ро ворид намоед: ");
            int c = Convert.ToInt32(Console.ReadLine());
            bool abc = (a < b && b < c) || (c < b && b < a);
            Console.WriteLine($"Ададхои ворид намудаи шумо: \na = {a}, \nb = {b}, \nc = {c} чавоб: {abc}");
        }
    }
}