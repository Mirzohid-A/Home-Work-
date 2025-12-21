using System;
namespace Boolean5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ду ададхои бутун a ,b дода шудааст.Дурустии гуфтори он Нобаробарихои a>0 ё b<-2 дуруст аст санчида мебинем.\n Адади a - ро дохил намоед:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Адади b -ро дохил намоед");
            int b = Convert.ToInt32(Console.ReadLine());
            bool test = a>=0 || b<-2;
            Console.WriteLine($"Адади дохил кардагитон a = {a}, b = {b} = {test} аст");
        }
    }
}