using System;
namespace Begin13
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Радиуси доираро дохил намоед r1 = ?");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Радиуси доираро дохил намоед r2 = ?");
            double r2 = Convert.ToDouble(Console.ReadLine());
            var s1 =Math.PI * Math.Pow(r1, 2);
            var s2 = Math.PI * Math.Pow(r2, 2);
            var s3 = s1 - s2;
            Console.WriteLine("Майдони доираи калон = " + s1);
            Console.WriteLine("Майдони доираи хурд = " + s2);
            Console.WriteLine("Майдони байни доирахо = " + s3);

        }
    }
}