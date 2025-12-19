using System;
namespace Begin7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(" R окружности =?");
            double r = Convert.ToDouble(Console.ReadLine());
            var l = 2 * Math.PI * r;
            var s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Длина окружоности L=" + l + "и Площадь S=" + s);
        }
    }
}