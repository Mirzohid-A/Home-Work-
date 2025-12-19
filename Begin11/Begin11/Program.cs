using System;
   namespace Begon11
{
    class Program
    {
         static void Main()
        {
            Console.WriteLine("Адади а=?");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Адади b=?");
            int b = Convert.ToInt32(Console.ReadLine());
            var plus = Math.Abs(a + b);
            var minus = Math.Abs(a - b);
            var x = Math.Abs(a * b);
            var y = Math.Abs(a / b);
            Console.WriteLine("Модулий а+б = " + plus + "\nМодулий а-б = "+ minus + "\nМодулий a*B = " + x + "\nМодулий a/b = " +y);
        }
    }
}