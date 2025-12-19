using System;
 namespace Begin4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(" Диаметр =?");
            int d = Convert.ToInt32(Console.ReadLine());
            double l = Math.PI * d;
           
            Console.WriteLine($"Диаметр d = {d} \nPi = 3.14, \nответ = {l} ");
        }
    }
}s