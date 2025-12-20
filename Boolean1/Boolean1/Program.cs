using System;
namespace Boolean1 { 
    class Program
    {
        static void Main()
        {
            Console.Write("Барои сачидани адад дурст ё нодурст\nАдади  a - ро дохил намоед: ");
            int a = Convert.ToInt32(Console.ReadLine());
            bool manfi = a < 0;
            bool musbat = a > 0;

            switch (manfi)
            {
                case false:
                    Console.WriteLine($"Адади дохил кардагитон {a} - {manfi} аст");
                    break;
                case true:
                    Console.WriteLine($"Адади дохил кардагитон {a} - {musbat} аст");
                    break;
                default:
                    Console.WriteLine($"Адади дохил кардагитон ба {a} Нул  барорбар аст\n Дуруст интихоб намоед ");
                    break;

            }
           
        }
    }
}