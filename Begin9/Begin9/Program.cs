using System;
   namespace Begin9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числло B:");
            int b = Convert.ToInt32(Console.ReadLine());
            var s = Math.Sqrt(a * b);
            Console.WriteLine("Среднее геометрическое чисел A и B равно: " + s);
        }
    }
}