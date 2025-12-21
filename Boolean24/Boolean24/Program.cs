using System;
namespace Boolean24
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ададҳои a, b, c дода шудаанд(адади a ба 0 баробар нест).Аз рӯи қимати дискриминант , дурустиии гуфтори  «Муодилаи квадратии  решаҳои ҳақиқӣ дорад» санҷида шавад.\nАдади a - ро дохил намоед:");
            double a =Convert.ToDouble(Console.ReadLine());
            Console.Write("Адади b - ро дохил намоед");
            double b =Convert.ToDouble(Console.ReadLine());
            Console.Write("Адади c - ро дохил намоед:");
            double c = Convert.ToDouble(Console.ReadLine());
            var s = a != 0;
            double d = Math.Pow(b, 2) - 4 * a * c;
            bool result = d >= 0;
            Console.WriteLine("Муодилаи квадрати решахои вокеи дорад: " + result);




        }
    }
}