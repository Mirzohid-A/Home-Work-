using System;
namespace IF_24
{
    class Program
    {
        static void Main()
        {
            Console.Write("Адади хакикии додашудаст х кимати функсияи зерини f, \r\nки киматхои хакики кабул мекунад, ёфта шавад:");
            float x = float.Parse(Console.ReadLine());
            double fx;
            
            if (x > 0)
            {
                fx = 2 * Math.Sin(x);
              
            }
            else 
            {
               fx = x - 6;
            }
            Console.WriteLine($"f({x}) = {fx}");
        }
    }
    }