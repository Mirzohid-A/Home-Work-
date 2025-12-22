using System;
namespace IF_25
{
    class Program
    {
        static void Main()
        {
            Console.Write("Барои кимати хакикии додашудаи х кимати функсияи зерини 𝑓, \r\nки киматхои хакики кабул мекунад, ёфта шавад: ");
                float x = float.Parse(Console.ReadLine());
            double fx;
            if (x <- 0||x>2)
            {
                fx = 2 * x;
            }
            else
            {
                fx = -3 * x;
            }
            Console.WriteLine($"f(x) = {fx}");
        }
    }
}