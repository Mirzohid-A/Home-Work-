using System;
namespace IF_6
{
    class Program
    {
        static void Main()
        {
            Console.Write("Адади якумро дохил намоед: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Адади дуюмро дохил намоед: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number >= number2)
            {
                Console.WriteLine($"Адади якум калон аст {number} > {number2}.");
            }
            else if (number < number2)
            {
                Console.WriteLine($"Адади дуюм калон аст{number} < {number2}.");
            }
            else if (number == number2)
            {
                Console.WriteLine($"Ададхо баробар мебошанд{number} = {number2}.");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}