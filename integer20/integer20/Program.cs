using System;
 namespace integer20
{
    class Program
    {
        static void Main()
        {
            Console.Write("Соатро бо сония дохил намоед: ");
            double n = Convert.ToDouble(Console.ReadLine());
            var x = n / 3600;
            Console.WriteLine("Сонияхо бо соат = " + x);
        }
    }
}