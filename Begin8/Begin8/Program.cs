using System;
 namespace Begin8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("a=?");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b=?");
            int b = Convert.ToInt32(Console.ReadLine());
            var s = (a + b) / 2;
            Console.WriteLine("среднее арифметическое" + s);
        }
    }
}