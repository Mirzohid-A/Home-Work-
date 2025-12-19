using System;
 namespace Begin12
{
    class Program
    {
        static void Main()
        {
        Console.WriteLine("Адади A - ро дохил намоед = ?");
            double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("B -ро дохил намоед");
            double b = Convert.ToDouble(Console.ReadLine());
            var c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            var p =a + b + c;
            Console.WriteLine("Гипотенузаи С = " + c + "\nПериметри он " + p);


        }
    }
}