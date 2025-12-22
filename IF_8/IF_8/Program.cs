using System;
namespace IF_8
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ду ададхо дода шудааст. Аввал калонтарин, баъд хурдтарини \r\nонхоро аз чоп бароварда, санчида шавад \nАдади якумро дохил намоед:");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Адади дубмро дохил намоед:");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            if (numberOne > numberTwo)
            {
                Console.WriteLine($"Адади якум калон аст {numberOne};\nАдади дуюм хурд аст {numberTwo}");
            }
            else if (numberOne < numberTwo) 
            {
                Console.WriteLine($"Адади дуюм калон аст {numberTwo};\nАдади дуюм хурд аст {numberOne}");
            }
            else
            {
                Console.WriteLine("Дохили шумо нодурст аст");
            }

        }
    }
}