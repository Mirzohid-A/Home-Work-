using System;
namespace Begin10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("введите число=?");
            double a =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число=?");
            double b = Convert.ToDouble(Console.ReadLine());
            var a1 = Math.Pow(a,2);
            var b1 = Math.Pow(b, 2);
            var c1 = a1 + b1;
            var c2 = a1 - b1;
            var c3 = a1 * b1;
            var c4 = a1 / b1;
            Console.WriteLine("сумa=" + c1 + "\n разность =" +c2 + "\n произведение ="+ c3 + "частное ="+ c4);
        }
    }
}