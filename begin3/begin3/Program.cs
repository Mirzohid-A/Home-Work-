using System;
 namespace begin3
{
     class Program 
      {
        static void Main()
        {
            Console.WriteLine("Строны прямаугольника, a =?");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону прямоугольника b=?");
            int b = int.Parse(Console.ReadLine());
            int s = a * b;
            int p =2 * (a + b);
            Console.WriteLine($"Площадь прямаугольника  = {s}, Периметр = {p}");
        }  
      }
}