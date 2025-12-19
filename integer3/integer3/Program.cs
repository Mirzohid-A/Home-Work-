using System;
    namespace integer3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ададхои бутуни мусбати А - ро дохил намоед:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ададхои бутуни мусбати B - ро дохил намоед:");
            int b = Convert.ToInt32(Console.ReadLine());
            int r = a / b;
            Console.WriteLine("Натича" + r);

        }
    }
}