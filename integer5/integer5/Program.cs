using System;
namespace integer5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Адади А - ро дохил намоед:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Адади B - ро дохил намоед:");
            double b = Convert.ToDouble(Console.ReadLine());
            var ts = a % b;
            Console.WriteLine("Қимати қисми даҳии натиҷаи тақсими А ба B: " + ts);

        }
    }
}