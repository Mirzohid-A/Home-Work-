using System;
     namespace integer4
     {
       class Program
    {
        static void Main()
        {
            Console.Write("Ададхои бутуни мусбати А-ро дохил намоед:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ададхои бутуни мусбати B - ро дохил намоед:");
            int b = int.Parse(Console.ReadLine());
            var m = a / b;
            Console.WriteLine("натича= " + m);
        }
    }
     }