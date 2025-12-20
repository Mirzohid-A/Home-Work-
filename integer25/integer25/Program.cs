using System;
namespace integer25
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Рузхои хафта чунин ракамхо дохил намоед:");
            int k = Convert.ToInt32(Console.ReadLine());
            int oneday = 4;
            int n =( oneday+(k-1))% 7;
            if (n == 0)
            {
                Console.WriteLine("Якшанбе");

            } else if(n == 1 )
            {
                Console.WriteLine("Душанбе");
            } else if (n == 2)
            {
                Console.WriteLine("Сешанбе");
            } else if (n == 3)
            {
                Console.WriteLine("Чоршанбе");
            } else if(n == 4)
            {
                Console.WriteLine("Пайшанбе");
            } else if(n == 5)
            {
                Console.WriteLine("Чумъа");
            } else if (n == 6)
            {
                Console.WriteLine("Шанбе");
            }
            else
            {
                Console.WriteLine("Рузро бо ракамхои  аз 0 - 7 истифода шавад!");
            }
        }
    }
}