using System;
namespace Boolean8
{
    class Program
    {
        static void Main()
        {
            Console.Write("Boolean8. Ду ададхои бутуни a, b дода шудаанд. Дурустии гуфтори: \r\n«Хар яке аз ададхои a ва b токанд» санчида шавад.\nАдади a - ро ворид намоед: ");
            int a = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Адади b - ро ворид намоед:");
            int b = Convert.ToInt32(Console.ReadLine());
            bool ab = a % 2  !=0 && b % 2 !=0;
            Console.WriteLine($"Адади дохил намудаи шумо: \na = {a};\nb = {b};\nНатича:{ab}");
        }
    }
}