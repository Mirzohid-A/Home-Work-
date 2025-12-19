using System;
namespace Begin6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите длины ребер a=?");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длиный ребер b=?");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длины ребер с=?");
            int c = Convert.ToInt32(Console.ReadLine());
            var v = a * b * c;
            var s = 2 * (a * b + b * c + a * c);
            Console.WriteLine("Объем параллелепипеда v=" + v);
            Console.WriteLine("Площадь поверхности s =" + s);
        }
    }
}