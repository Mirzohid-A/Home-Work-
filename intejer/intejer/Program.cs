using System;
namespace intejer
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Дарозиро бо сантиметр ворид кунед:");
            int l = Convert.ToInt32(Console.ReadLine());
            int metr = l / 100;
            Console.WriteLine("Дарози дар метр:" + metr);
        }
    }
}