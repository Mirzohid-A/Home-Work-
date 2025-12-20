using System;
namespace Boolean4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ду ададхои бутуни a, b дода шудаанд. Дурустии гуфтори: \r\n«Нобаробарихои a  ва b дуруст аст санчида шавад. ");
            Console.Write("Адади А - ро ворид намоед:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Адади B - ро ворид намоед:");
            int b = Convert.ToInt32(Console.ReadLine());
            bool result = a > 2 || b < 3;
            if (result)
            {
                Console.WriteLine($"Дурст:{result}");
            }
            else
            {
                Console.WriteLine($"Нодурст: {result}");
            }

        }
    }
}