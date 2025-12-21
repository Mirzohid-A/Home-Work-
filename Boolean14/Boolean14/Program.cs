using System;
namespace Boolean14
{
    class Program
    {
        static void Main()
        {
            Console.Write("Се ададхои бутуни a, b, c дода шудаанд. Дурустии гуфтори: \r\n«Танхо яке аз ададои a, b, c мусбат аст» санчида шавад.\nАдади a - ро ворид намоед:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Адади b - ро ворид намоед:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Адади c - ро ворид намоед:");
            int c = Convert.ToInt32(Console.ReadLine());
            bool test = a < 0 || b < 0 || c < 0;

            if (a < 0)
            {
                Console.WriteLine($"Адади ворид намудаи шумо: \na = {a}; \nb = {b}; \nc = {c};\nНатича 'a'» {test}");
            }
            else if (b < 0)
            {
                Console.WriteLine($"Адади ворид намудаи шумо: \na = {a}; \nb = {b}; \nc = {c};\nНатича 'b' {test}");
            }
            else if (c < 0)
            {
                Console.WriteLine($"Адади ворид намудаи шумо: \na = {a}; \nb = {b}; \nc = {c};\nНатича 'c'» {test}");
            }
            else 
            {
                Console.WriteLine("НОДУРСТ" + test);
            }





            }
    }
}
