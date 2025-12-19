using System;
 namespace integer19
{
    class Program
    {
        static void Main()
        {       
            Console.Write("Рузро бо сония дохил намоед:");
            int n = Convert.ToInt32(Console.ReadLine());
            int r = n / 60;
            Console.WriteLine("Сония бо минут = "+ r);
        }
    }
}