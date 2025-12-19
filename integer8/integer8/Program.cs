using System;
namespace integer8
{
    class Program
    {
        static void Main()
        {
            //Random r = new Random();
            Console.Write("Ададхои серакама дохил намоед:");
            int x = Convert.ToInt32(Console.ReadLine());
            int r = (x % 10) *10 + (x / 10);
           Console.WriteLine(r);
        }
    }
}