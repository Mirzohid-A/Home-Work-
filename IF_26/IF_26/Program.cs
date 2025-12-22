using System;
namespace IF_26
{
    class Program
    {
        static void Main()
        {
            Console.Write("Барои кимати хакикии додашудаи x кимати функсияи зерини 𝑓, \r\nки киматхои хакики кабул мекунад, ёфта шавад.\nx = ?");
            float x = float.Parse(Console.ReadLine());
            double fx = 0;
            if (x < 0)
            {
                fx = -x;
            }
            else if (x <= 2)
            {
                fx = Math.Pow(x, 2);
            }
            else if (x > 2)
            {
                fx = 4;
            }
            Console.WriteLine($"f(x) = {fx}");
        }
    }
}