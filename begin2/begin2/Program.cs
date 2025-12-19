using System;
    namespace begin2
{
    class Program 
    {
    static void Main()
        {
            Console.WriteLine("сторона квадрата a=?");
             double a = double.Parse(Console.ReadLine());
             double s = Math.Pow(a, 2);
            Console.WriteLine($"Площадь квадрата со стороной {a} = {s}");
        }
        
    }
}