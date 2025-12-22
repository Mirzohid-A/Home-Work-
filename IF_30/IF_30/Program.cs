using System;

class Program
{
    static void Main()
    {
        Console.Write("Ададро аз 1 то 999 ворид кунед: ");
        int number = int.Parse(Console.ReadLine());

        string psN;
        if (number % 2 == 0)
            psN = "чуфт";
        else
            psN = "ток";

        int digits = number.ToString().Length;
        string raqam;
        if (digits == 1)
            raqam = "як ракама";
        else if (digits == 2)
            raqam = "ду ракама";
        else
            raqam = "се ракама";

        Console.WriteLine($"Адади {psN} {raqam}");
    }
}
