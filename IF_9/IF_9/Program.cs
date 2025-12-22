using System;
namespace IF_9 
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ду тагйирёбандаи навъашон хакики: a, b дода шудааст. Кимати \r\nонхоро чунин иваз карда шавад ки a ба кимати хурдтарин ва b ба кимати калонтарин \r\nбаробар шаванд. Киматҳхи нави тагиирёбандахои a ва b-ро аз чоп бароварда шавад.\nАдади a - ро дохил намоед:");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Адади b - ро дохил намоед:");
            float b = float.Parse(Console.ReadLine());

            if (a > b)
            {
                float x = a;
                a = b;
                b = x;
                Console.WriteLine($"a = {a}");
                Console.WriteLine($"b = {b}");
            }
            else
            {
                Console.WriteLine("it's not numer!!");
            }
        }
    }
}