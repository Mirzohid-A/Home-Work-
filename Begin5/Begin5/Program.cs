using System;
namespace Begin5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("длина ребра куба a=?");
            int a = Convert.ToInt32(Console.ReadLine());
            var v = Math.Pow(a, 3);
            var s = 6 * Math.Pow(a, 2);
            Console.WriteLine("объем куба v=" + v + "площадь поверхности s=" + s);
        }
    }
}