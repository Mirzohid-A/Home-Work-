using System;
   namespace begin1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("сторона квадрата =?");
            int p = Convert.ToInt32(Console.ReadLine());
            int x = 4*p;
            Console.Write($"периметр {x} ");
        }
    }
}