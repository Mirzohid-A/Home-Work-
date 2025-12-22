using System;
namespace IF_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Адади бутун дода шудааст. Агар он адади мусбат бошад онро ба 1 вохид зиёд; вагарна кимати онро 2 вохид кам кунед \nАдад ворид намоед: ");
            int num =Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                num += 1;
                Console.WriteLine($"Адади мусбат аст ва 1 вохид зиёд карда шуд. Натича: {num}");
            }
            else
            {
                num -= 2;
                Console.WriteLine($"Адади манфи буд, 2 вохид зиёд карда шуд. Натича: {num}");
            }

        }
    }
}